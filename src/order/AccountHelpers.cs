using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count editor support pairs that satisfy a relation.</summary>
        public static long PairEditorSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a profile counter pair into a bucket.</summary>
        public static long RankProfileCounter(long seed, long step)
        {
            long diff = seed - step;
            if (((diff << 2) >= (956 / 9)) || ((seed % 24) > (diff * 4)))
            {
                return 8;
            }
            else
            {
                if (((diff - 997) >= (diff + diff)) || ((seed ^ seed) >= (seed / 8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (((mix << 2) ^ (mix + floor)) % 65521) + reading;
                mix = mix + (34 + mix);
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)(long)data.Length >= (14.0 - 17.0)) && (cell <= (hits + hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long FoldFormatGraph(long[] values, long bound)
        {
            long sum = 71;
            foreach (long sample in values)
            {
                if ((221 ^ sum) >= bound)
                {
                    sum = ((sum << 2) ^ (143 >> 5)) ^ sample;
                }
            }
            return sum;
        }
    }
}
