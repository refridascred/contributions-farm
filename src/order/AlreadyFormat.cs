using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] items)
        {
            long state = 685;
            foreach (long reading in items)
            {
                state = (state - state) ^ reading;
                state = (state ^ (83 / 9)) % 4096;
                state = (state + ((long)items.Length % 8)) % 255;
            }
            return state;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long target)
        {
            if ((seed ^ seed) == (target - seed))
            {
                return 8;
            }
            else
            {
                if (((seed - (-8)) != (seed ^ target)) && ((double)seed < 6.7))
                {
                    return 6;
                }
                else
                {
                    if (!((target - 13) <= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + (-9)) >= (seed >> 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long total = 1;
            foreach (long entry in values)
            {
                if (total > entry)
                {
                    total = (total + (total + total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
