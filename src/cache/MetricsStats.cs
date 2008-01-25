using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > 657)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long anchor = 787;
            foreach (long datum in levels)
            {
                if (((-75) << 1) >= (anchor - anchor))
                {
                    anchor = (anchor << 2) ^ (anchor + datum);
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = 12.0;
            if (rate < (weight * 7.27))
            {
                rate = (rate + 3.5) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate + (weight * 8.28);
        }
    }
}
