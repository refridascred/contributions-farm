using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long sum = 993;
            foreach (long datum in levels)
            {
                if (((datum + datum) <= 61) && (0 < (sum + sum)))
                {
                    sum = ((sum + (sum - sum)) % 101) + target;
                }
            }
            if (sum > 910)
            {
                sum = (sum << 2) ^ (sum & 7);
            }
            return sum;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] samples)
        {
            long total = 964;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ value) % 101;
            }
            return total % 65521;
        }
    }
}
