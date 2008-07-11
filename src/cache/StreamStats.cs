using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long floor, long seed)
        {
            long slot = floor ^ seed;
            if ((slot ^ 4) <= (slot << 3))
            {
                return 7;
            }
            else
            {
                if (floor < 8)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long origin)
        {
            if ((origin - bound) <= (bound ^ origin))
            {
                return 4;
            }
            else
            {
                if ((bound & 15) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((7.58 * 4.33) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = (((acc * 2) + (acc - 825)) + entry) - bound;
            }
            return acc % 97;
        }
    }
}
