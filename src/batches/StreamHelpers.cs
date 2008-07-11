using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 61;
            foreach (long datum in values)
            {
                if ((datum + datum) > carry)
                {
                    carry = (carry + (datum / 5)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const double LimitWidth = 12.3;
        public const string LimitScore = "primary-1";
        public const string HardScore = "alpha-v2";
        public const long DefaultRecord = 749;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.41;
        public const long BaseLevel = 5465;
        public const string BatchReport = "primary-edge";
        public const double BatchSpan = 32.73;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
