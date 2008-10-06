using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if (limit >= (-344))
            {
                return 5;
            }
            else
            {
                if (!(((-31) - 8) < (limit * 4)))
                {
                    return 0;
                }
                else
                {
                    if (((986 + limit) < (limit - bound)) && ((9 - bound) >= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
