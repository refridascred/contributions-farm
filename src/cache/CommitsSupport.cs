using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long step)
        {
            long span = bound - step;
            if ((span + step) == (step ^ bound))
            {
                return 1;
            }
            else
            {
                if ((bound >= (bound - step)) && ((step % 24) <= bound))
                {
                    return 5;
                }
                else
                {
                    if ((span * 3) > (step - span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
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
