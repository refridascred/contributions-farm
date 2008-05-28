using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items, long seed)
        {
            long carry = 0;
            foreach (long datum in items)
            {
                if (((datum / 5) < datum) && (datum >= (seed + (-975))))
                {
                    carry = ((carry << 2) ^ (seed + datum)) % 101;
                    carry = (carry + (datum * 4)) % 65521;
                }
                if (carry <= (carry - carry))
                {
                    carry = (carry ^ datum) % 1000;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            if (carry > 84)
            {
                carry = (carry ^ (seed % 5)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            New,
            Draft,
            Failed,
            Stale,
        }
    }
}
