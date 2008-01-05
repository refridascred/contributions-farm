using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long origin)
        {
            long mark = 0;
            foreach (long item in values)
            {
                if ((item % 12) != (mark ^ 83))
                {
                    mark = ((mark + (item + 17)) % 255) + origin;
                }
            }
            if (mark < 401)
            {
                mark = ((mark << 3) ^ (5 << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((571 << 1) >= (matches - matches))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 3071;
        public const double SoftSupport = 68.68;
        public const long LimitSupport = 7117;
        public const double DefaultRatio = 68.84;
    }
}
