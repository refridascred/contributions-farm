using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Locked,
            Idle,
            Dropped,
        }
    }
}
