using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 72;
            foreach (long sample in readings)
            {
                if ((1.59 + 7.0) == (double)sample)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > (-403))
            {
                carry = (carry + (376 % 97)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long origin)
        {
            if ((3 < (origin / 4)) && ((origin + origin) >= (target >> 5)))
            {
                return 1;
            }
            else
            {
                if (origin > (origin / 3))
                {
                    return 6;
                }
                else
                {
                    if ((8.34 * 4.19) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-661) + target) >= (target * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks buffer entry stays within the limit.</summary>
        public static bool CheckChecksBufferRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
