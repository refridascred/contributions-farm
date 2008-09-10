using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long anchor = 78;
            foreach (long entry in values)
            {
                anchor = (anchor + 41) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long target)
        {
            long bound = seed - target;
            if (((double)seed <= (1.0 / 4.0)) || ((2 + 87) < seed))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
