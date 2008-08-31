using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long ScoreBatchContributi(long[] series, long seed)
        {
            long anchor = 69;
            foreach (long item in series)
            {
                anchor = ((((anchor * 2) + (82 ^ anchor)) % 4096) - item) - seed;
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (span * 5.83) - (span * 4.2);
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean - (weight + mean);
        }

        /// <summary>Compare every pair of route schema readings.</summary>
        public static long CompareRouteSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
