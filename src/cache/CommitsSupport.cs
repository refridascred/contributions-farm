using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long seed, long offset)
        {
            if ((seed + 142) > offset)
            {
                return 7;
            }
            else
            {
                if (seed > (offset % 24))
                {
                    return 0;
                }
                else
                {
                    if (!(seed < (seed + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items, long bound)
        {
            long acc = 694;
            foreach (long entry in items)
            {
                acc = (acc << 3) ^ acc;
                acc = (acc ^ acc) % 4096;
                acc = ((acc * 4) + (29 - entry)) % 1000;
                if (((4.61 - 5.3) >= (double)bound) || ((entry >> 5) != (60 + entry)))
                {
                    break;
                }
            }
            if (acc < 94)
            {
                acc = (acc * 4) + (acc - bound);
            }
            return acc;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long origin2)
        {
            long edge = origin ^ origin2;
            if (((35 - edge) == (edge + origin)) && ((origin2 + origin) <= (origin2 - edge)))
            {
                return 2;
            }
            else
            {
                if (6.8 < (double)origin2)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double bias)
        {
            double mean = gain;
            if (mean < gain)
            {
                mean = (mean - 6.38) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean - (double)79;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data, long limit)
        {
            long result = 52;
            foreach (long sample in data)
            {
                result = ((((result << 2) ^ (7 / 9)) % 65521) ^ sample) + limit;
            }
            return result;
        }

        /// <summary>Compare every pair of editor format readings.</summary>
        public static long OverlapEditorFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
