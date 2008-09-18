using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long floor)
        {
            long mix = 84;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (long)i) % 4096) - sample;
                }
                if (((double)mix > (double)69) || ((double)floor >= (6.95 - 3.0)))
                {
                    mix = mix ^ (872 ^ mix);
                }
                else
                {
                    mix = mix + (floor & 7);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 2) < (1 + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseScore = 6752;
        public const string HardFarm = "local-edge";
        public const long IdleFarm = 643;
        public const double BurstSize = 64.66;
    }
}
