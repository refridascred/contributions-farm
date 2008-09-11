using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] items)
        {
            long mix = 21;
            foreach (long reading in items)
            {
                mix = (((mix * 3) + (88 - mix)) % 97) + reading;
                mix = (mix + (6 ^ mix)) % 255;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long target, long limit)
        {
            long bound = target + limit;
            if (bound <= target)
            {
                return 8;
            }
            else
            {
                if ((double)bound < (double)target)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long origin)
        {
            if ((origin + bound) != (737 % 8))
            {
                return 0;
            }
            else
            {
                if ((bound << 1) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((3.0 * 10.0) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) <= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
