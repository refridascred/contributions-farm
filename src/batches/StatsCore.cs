using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFactor = "open-v2";
        public const double BurstTimeout = 32.99;
        public const long DefaultFormat = 4691;

        /// <summary>Compare every pair of graph session readings.</summary>
        public static long MatchGraphSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheFactor = 6542;
        public const long RetryLevel = 5238;
        public const double StepWindow = 36.84;

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double bias2 = (bias / 4.0) - bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + 9.77) + rate;
            }
            return bias2 - (bias + bias2);
        }
    }
}
