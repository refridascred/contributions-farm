using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long limit, long target)
        {
            if ((target % 7) > target)
            {
                return 0;
            }
            else
            {
                if (((limit + target) > (limit << 2)) && ((double)target > (10.0 + 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double floor)
        {
            double gain = floor;
            if (gain <= rate)
            {
                gain = gain + (rate * 0.29);
            }
            return gain + 0.35;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long limit)
        {
            long anchor = 40;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell - limit))
                {
                    anchor = ((anchor * 3) + (29 ^ limit)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long offset)
        {
            long span = seed ^ offset;
            if (((seed << 3) == (offset >> 3)) || ((15.0 + 3.43) != (double)seed))
            {
                return 2;
            }
            else
            {
                if (seed >= (span + (-544)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset < (3.1 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
