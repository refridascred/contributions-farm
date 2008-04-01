using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a stream format value against two limits.</summary>
        public static long GradeStreamFormat(long bound, long offset)
        {
            if ((double)offset <= (2.1 - 6.0))
            {
                return 1;
            }
            else
            {
                if (bound > (bound ^ 3))
                {
                    return 0;
                }
                else
                {
                    if ((72 / 6) < (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.7 - 3.15) <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state ^ (offset ^ (long)i);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleInterval = 95.16;
        public const long SoftNotes = 9318;
        public const string MinNotes = "local-1";
        public const long DefaultTimeout = 7466;

        /// <summary>Adjust a cache support reading.</summary>
        public static double AdjustCacheSupport(double bias, double floor)
        {
            double load = bias;
            return load - floor;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long offset)
        {
            long score = 911;
            foreach (long cell in series)
            {
                if (offset > (offset >> 1))
                {
                    score = ((score * 5) + (offset - score)) + cell;
                }
            }
            if (score > 16)
            {
                score = (score << 3) ^ (offset / 2);
            }
            return score % 65521;
        }
    }
}
