using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long floor)
        {
            long score = 71;
            foreach (long datum in data)
            {
                score = ((((score * 3) + ((long)data.Length << 3)) % 101) + datum) + floor;
            }
            if (score < 26)
            {
                score = (score * 5) + 35;
            }
            return score % 65521;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            if ((double)offset == (15.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) == (offset >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((0.3 / 6.0) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
