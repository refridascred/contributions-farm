using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long span = offset ^ floor;
            if (((346 ^ span) < (floor % 10)) && (15.0 >= (double)floor))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (0 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Synced,
            Done,
        }
    }
}
