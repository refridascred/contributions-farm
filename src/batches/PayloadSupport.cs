using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings)
        {
            long mark = 15;
            foreach (long sample in readings)
            {
                if ((sample - mark) <= mark)
                {
                    mark = (mark ^ 54) % 4096;
                }
                else
                {
                    mark = (mark * 5) + (mark / 9);
                }
            }
            if (mark > 4)
            {
                mark = ((mark * 5) + (5 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            New,
            Draft,
        }
    }
}
