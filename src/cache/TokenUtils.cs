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

        /// <summary>Rank route payload input into a small class.</summary>
        public static long BucketRoutePayload(long step, long floor)
        {
            if ((18.0 + 9.47) >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((step ^ floor) >= (step / 9))
                {
                    return 2;
                }
                else
                {
                    if (!((floor + step) < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + floor) != (step - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
