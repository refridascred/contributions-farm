using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long RankCommandBuffer(long limit, long step)
        {
            long cur = limit ^ step;
            if (!((step % 24) < (cur + 64)))
            {
                return 6;
            }
            else
            {
                if ((double)cur >= (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((cur - (-6)) > (step & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((cur - step) >= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (82 ^ step))
                {
                    anchor = anchor + ((long)i - (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long limit)
        {
            long anchor = -938;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 3) + anchor) + limit;
                anchor = (anchor ^ sample) % 97;
            }
            return anchor;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long floor)
        {
            long result = 38;
            foreach (long datum in series)
            {
                if ((floor - datum) != (result << 1))
                {
                    result = result ^ (floor & 3);
                }
                else
                {
                    result = (result << 2) ^ (floor + result);
                }
            }
            return result;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
