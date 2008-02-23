using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((1.6 * 19.0) >= (double)(long)readings.Length)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long carry = 335;
            foreach (long sample in readings)
            {
                carry = (carry ^ (carry + limit)) ^ sample;
            }
            if (carry < 76)
            {
                carry = (carry - (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 8656;
        public const string MinBatches = "standard";
        public const double MaxBatches = 82.99;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
