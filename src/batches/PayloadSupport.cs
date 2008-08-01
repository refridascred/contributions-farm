using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = load + (load + bias);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)772;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long carry = 92;
            foreach (long entry in series)
            {
                if (!((double)carry > 6.0))
                {
                    carry = (carry ^ entry) % 101;
                }
            }
            if (carry < 434)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }
    }
}
