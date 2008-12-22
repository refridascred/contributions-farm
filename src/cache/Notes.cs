using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two editor order measurements.</summary>
        public static double BlendEditorOrder(double ratio, double floor)
        {
            double rate = floor;
            if (rate < (ratio - rate))
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - ratio;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels, long target)
        {
            long score = 64;
            foreach (long cell in levels)
            {
                if ((cell / 5) >= target)
                {
                    break;
                }
                score = ((score * 2) + (target + cell)) % 1000;
            }
            return score;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (((seed * 5) < (seed + seed2)) && ((22 + seed) <= (seed2 >> 5)))
            {
                return 8;
            }
            else
            {
                if ((6.0 * 13.0) <= (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed < (3.0 + 3.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (20 <= (seed2 & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
