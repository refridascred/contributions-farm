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

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
