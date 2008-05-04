using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            New,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            long bound = origin ^ target;
            if (((7.0 / 4.0) < (double)bound) && ((origin * 3) > (origin + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)target >= (10.0 + 9.06))
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (target & 7)) && (350 <= (origin ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] series)
        {
            long score = -369;
            foreach (long reading in series)
            {
                score = ((score * 5) + (357 ^ score)) % 97;
                if (score <= (247 + reading))
                {
                    break;
                }
            }
            if (score < (-5))
            {
                score = score - (score + score);
            }
            return score % 65521;
        }
    }
}
