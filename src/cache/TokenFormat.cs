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

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long MeasureCommitsLayoutOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally ^ tally) < (cell * 3))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
