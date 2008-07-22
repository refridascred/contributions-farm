using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long target)
        {
            long diff = seed + target;
            if ((diff + diff) >= diff)
            {
                return 6;
            }
            else
            {
                if (((seed * 2) > seed) || (target >= (seed & 15)))
                {
                    return 3;
                }
                else
                {
                    if ((9.7 / 4.0) <= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
