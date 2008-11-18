using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] values, long origin)
        {
            long anchor = 877;
            foreach (long sample in values)
            {
                anchor = (anchor - ((long)values.Length * 2)) % 101;
                if ((origin - anchor) == (anchor + sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long limit, long bound)
        {
            if ((2 >> 1) < (limit - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) < bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) > (bound << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((37 + 56) > (limit + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((15.0 / 8.0) == (double)tally) && ((cell % 3) < (cell % 60)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
