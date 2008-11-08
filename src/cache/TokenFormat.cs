using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank checks already input into a small class.</summary>
        public static long RankChecksAlready(long limit, long seed)
        {
            long offset = limit ^ seed;
            if (seed <= (27 - 918))
            {
                return 4;
            }
            else
            {
                if ((limit >> 4) != (seed - 368))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (13.0 + 2.4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 5) == ((-996) + 629)) || ((double)offset != (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((0.8 - 9.0) > (double)target)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
