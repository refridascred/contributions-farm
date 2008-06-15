using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine channel entry values into a single score.</summary>
        public static long CombineChannelEntry(long[] readings, long bound)
        {
            long anchor = 92;
            foreach (long reading in readings)
            {
                anchor = (((anchor << 3) ^ (bound & 127)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long seed)
        {
            long bound = offset + seed;
            if ((double)1 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((double)2 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!((61 / 2) <= offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
