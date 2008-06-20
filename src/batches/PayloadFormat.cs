using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support command value from a seed.</summary>
        public static long IterateSupportCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((carry - (-1)) >= carry))
                {
                    carry = carry ^ (target * 4);
                    carry = (carry - (target & 15)) % 1000;
                }
                carry = (carry ^ (carry % 8)) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items, long floor)
        {
            long mark = 601;
            foreach (long cell in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark ^ 0) % 255) + (long)i) + cell;
                }
                if (((454 % 100) != (long)items.Length) || (((-50) + mark) > (floor + floor)))
                {
                    mark = (mark - mark) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (82 * 5);
                }
            }
            if (mark < 875)
            {
                mark = (mark + floor) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((2.1 + 17.0) >= (7.4 - 1.8))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Closed,
            Pending,
        }
    }
}
