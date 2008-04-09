using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((2 % 10) > (edge + bound)) || ((edge - edge) <= (-505)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) < bound2)
                {
                    return 3;
                }
                else
                {
                    if ((963 & 1) < bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
