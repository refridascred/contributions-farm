using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((6.61 / 7.0) != (double)seed)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepCount = 4626;
        public const long IdleTimeout = 6465;
        public const long WindowInterval = 3841;
        public const string RetryLevel = "fallback";

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double weight = 15.0;
            if (weight <= (floor / 6.0))
            {
                weight = (weight - floor) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + 5.2) + (double)(long)i;
            }
            return weight - (double)678;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values, long seed)
        {
            long carry = 3;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (cell - 522)) % 65521;
                if (((carry - 11) != (44 % 8)) || ((cell << 2) <= ((-359) << 2)))
                {
                    carry = carry + (carry - carry);
                    carry = (carry + (carry - carry)) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ (3 * 5);
                    carry = (carry ^ (long)values.Length) % 101;
                }
                if ((4.4 / 6.0) < (double)seed)
                {
                    carry = (carry ^ (seed + cell)) % 255;
                }
            }
            return carry;
        }
    }
}
