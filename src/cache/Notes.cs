using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long carry = 98;
            foreach (long cell in readings)
            {
                if ((double)cell < (6.0 + 2.0))
                {
                    carry = carry ^ (5 << 1);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long seed)
        {
            long anchor = 76;
            foreach (long item in data)
            {
                if ((seed * 3) > (item % 7))
                {
                    anchor = (anchor << 3) ^ (anchor + (long)data.Length);
                }
            }
            return anchor;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long bound, long target)
        {
            long prev = bound + target;
            if ((bound >> 2) > (target + prev))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (8.0 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if (((double)target <= (5.0 * 14.0)) && ((target + target) <= (bound - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev >> 1) < 482)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
