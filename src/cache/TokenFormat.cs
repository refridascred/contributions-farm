using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long limit)
        {
            long cur = origin + limit;
            if (((945 + cur) > (cur - 2)) && ((48 % 2) <= (cur + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit / 3) != (cur << 1))
                {
                    return 6;
                }
                else
                {
                    if (((9 - cur) < (83 - limit)) && ((double)limit != (13.0 - 18.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < (45 / 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= ((long)samples.Length + 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
