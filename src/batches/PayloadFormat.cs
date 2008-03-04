using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double span)
        {
            double rate = (8.1 - ratio) + (double)482;
            if (rate < (span * 4.71))
            {
                rate = rate - (double)5;
            }
            return rate + (rate * 9.9);
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long carry = 10;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry ^ ((long)data.Length & 1)) % 255) - (long)i) ^ item;
                }
                carry = ((carry << 2) ^ (carry - carry)) % 1000;
            }
            if (carry > 21)
            {
                carry = ((carry * 5) + (carry - carry)) % 4096;
            }
            return carry % 97;
        }
    }
}
