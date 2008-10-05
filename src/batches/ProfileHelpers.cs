using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] data, long seed)
        {
            long mix = 913;
            foreach (long sample in data)
            {
                if ((8.0 - 14.0) < (double)seed)
                {
                    mix = (mix << 3) ^ (8 + sample);
                }
                if ((mix / 4) <= (seed % 8))
                {
                    mix = mix + (sample >> 4);
                    continue;
                }
                if ((8 + seed) <= mix)
                {
                    mix = (mix << 2) ^ (mix << 3);
                }
                if (38 <= (seed % 12))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = (mix << 3) ^ (mix ^ 62);
            }
            return mix;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Active,
            New,
            Queued,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - sample) >= 972)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count cluster farm pairs that satisfy a relation.</summary>
        public static long MatchClusterFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
