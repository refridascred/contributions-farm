using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long ScoreStreamBuffer(long[] series, long origin)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                if (((sum + sum) == (origin - origin)) && (sum < (reading - origin)))
                {
                    sum = ((sum * 4) + (sum % 24)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long SeriesReportChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i != (5.66 / 3.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 8)) % 1000;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
