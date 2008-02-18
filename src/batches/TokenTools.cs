using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((4.1 / 2.0) != (double)hits)
                {
                    hits = ((hits + 1) - entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long origin, long bound)
        {
            long edge = origin - bound;
            if ((64 <= (bound % 12)) && ((origin - bound) == (bound + origin)))
            {
                return 3;
            }
            else
            {
                if ((bound + 823) < 26)
                {
                    return 1;
                }
                else
                {
                    if ((bound + origin) > edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + 88) > 1)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
