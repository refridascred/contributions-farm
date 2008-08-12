using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Idle,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long TallyFilterToolsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count != (4.4 + 3.17))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph entry samples are out of range.</summary>
        public static long AuditGraphEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value ^ count) >= (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - 7) > (target + target))
            {
                return 4;
            }
            else
            {
                if (target > (target ^ 71))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)857)
            {
                bias = bias + bias;
            }
            return bias + floor;
        }

        /// <summary>Count graph entry pairs that satisfy a relation.</summary>
        public static long PairGraphEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
