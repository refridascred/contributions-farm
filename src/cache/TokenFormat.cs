using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Roll a already checks counter forward.</summary>
        public static long StepAlreadyChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((offset2 + offset2) <= (bound ^ 306))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) < (offset % 60))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
