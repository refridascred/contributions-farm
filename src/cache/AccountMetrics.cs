using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long RollGithubfarmAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((4.19 * 7.87) != (double)bound)
                {
                    anchor = anchor - (bound ^ anchor);
                }
                if ((double)(long)i < (0.1 + 5.0))
                {
                    anchor = (anchor * 3) + (bound + bound);
                    continue;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.6 - 1.0) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor schema entry that matches the target.</summary>
        public static long LookupEditorSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor cluster input into a small class.</summary>
        public static long RankEditorCluster(long limit, long offset)
        {
            long next = limit + offset;
            if ((limit % 8) != (limit - 11))
            {
                return 5;
            }
            else
            {
                if ((next & 31) == ((-5) % 60))
                {
                    return 4;
                }
                else
                {
                    if (687 > (limit << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long CombineBufferMetric(long[] items)
        {
            long mix = 238;
            foreach (long item in items)
            {
                mix = (mix ^ (item + (-51))) % 101;
            }
            return mix % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
