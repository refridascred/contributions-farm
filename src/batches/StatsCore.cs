using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 466;
            foreach (long sample in values)
            {
                long count = sample << 2;
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (556 - count)) % 101) + (long)i;
                }
                if (((sample - sample) > (score - score)) || ((score * 3) > (sample % 7)))
                {
                    score = (score + (score * 3)) % 1000;
                }
                if (((sample - score) <= ((-232) / 5)) || ((double)sample == (9.2 - 17.0)))
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = (score ^ (score % 3)) % 255;
            }
            return score;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            if ((1.59 + 9.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - 309) >= (offset % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-36) >> 5) == (192 + offset)) && ((6.83 - 8.7) <= (double)offset))
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

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxWidth = 87.14;
        public const double BurstSpan = 65.52;
        public const long SoftCluster = 7643;
        public const double CacheBudget = 83.69;
        public const double BatchSpan = 14.93;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Closed,
            Locked,
            Queued,
            Pending,
        }
    }
}
