using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((-5) + seen) <= (776 + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long StepChecksQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (acc - (long)i);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of support context entries.</summary>
        public static long DigestSupportContext(long[] items)
        {
            long carry = 66;
            foreach (long item in items)
            {
                if (((-48) % 60) >= (item % 60))
                {
                    carry = (carry - (carry & 255)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Synced,
            Retry,
        }
    }
}
