using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two farm channel measurements.</summary>
        public static double ScaleFarmChannel(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (drift / 2.0))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (7.57 * 9.9);
        }

        /// <summary>Count cluster profile pairs that satisfy a relation.</summary>
        public static long CompareClusterProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double bias2 = bias;
            return bias2 - gain;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Locked,
            Draft,
            New,
            Failed,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (338 >= (cur >> 1))
            {
                return 1;
            }
            else
            {
                if ((cur / 5) != (2 * 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
