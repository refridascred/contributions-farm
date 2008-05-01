using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            if ((step << 3) > step)
            {
                return 1;
            }
            else
            {
                if (((step >> 1) >= step) || (step > (47 + floor)))
                {
                    return 8;
                }
                else
                {
                    if (!(step <= (227 % 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
