using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1395;
        public const long IdleFactor = 2575;
        public const double BatchSize = 71.17;
        public const long LimitFactor = 6349;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = -3;
            foreach (long entry in levels)
            {
                if ((10.0 + 6.69) == (double)entry)
                {
                    break;
                }
                mark = (mark - mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Match up stats counter samples.</summary>
        public static long OverlapStatsCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double load = rate;
            if (load >= (double)432)
            {
                load = load + rate;
            }
            else
            {
                load = load - (rate - floor);
            }
            return load - (double)227;
        }
    }
}
