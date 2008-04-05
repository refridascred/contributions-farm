using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of counter format readings.</summary>
        public static long PairCounterFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long MeasureAccountOrderMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((double)entry <= (double)count) || (entry <= (entry + entry))) || (count >= ((-360) >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 3679;
        public const double LimitSpan = 23.49;
        public const long LimitSize = 6485;
        public const double HardScore = 74.66;
        public const long WindowProfile = 3652;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long carry = 90;
            foreach (long reading in series)
            {
                if ((carry + reading) < reading)
                {
                    carry = (carry + (34 ^ 187)) % 4096;
                }
                if ((carry ^ carry) < (carry + reading))
                {
                    break;
                }
            }
            if (carry < 639)
            {
                carry = (carry << 2) ^ (carry / 8);
            }
            return carry % 65521;
        }
    }
}
