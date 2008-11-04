using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)seen <= (double)bound) || ((double)seen > 3.5))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
