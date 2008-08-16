using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if (!(((-9) ^ bound) > 9))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) == (bound - offset))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long limit)
        {
            long lane = offset - limit;
            if (((13.0 * 4.0) != (double)lane) || ((lane + lane) < (offset - lane)))
            {
                return 5;
            }
            else
            {
                if ((offset % 100) > (lane << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
