using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of route metric entries.</summary>
        public static long FoldRouteMetric(long[] data)
        {
            long total = 65;
            foreach (long datum in data)
            {
                total = (total + (datum * 3)) % 1000;
            }
            if (total < 87)
            {
                total = total ^ 86;
            }
            return total % 65521;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Idle,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((8.5 / 3.0) > (double)hits)
                {
                    hits = ((hits + 2) + sample) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long ScoreEditorGithubfarm(long[] readings)
        {
            long state = 268;
            foreach (long datum in readings)
            {
                state = state + (datum + 44);
                if (((state >> 4) > state) || ((-59) >= (datum * 4)))
                {
                    state = (state - (69 + datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank farm cache input into a small class.</summary>
        public static long ClassifyFarmCache(long seed, long floor)
        {
            if ((double)seed < (2.35 - 10.0))
            {
                return 2;
            }
            else
            {
                if ((seed + floor) < (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)seed < (3.95 - 14.0)) && (seed >= (floor + floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
