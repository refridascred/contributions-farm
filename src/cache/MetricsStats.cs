using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchLevel = "fallback-1";
        public const string BatchNotes = "standard-1";
        public const double MaxNotes = 48.88;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long score = 44;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score * 5)) % 255) - limit;
                if ((datum * 4) > (755 + score))
                {
                    score = (score << 3) ^ ((long)readings.Length & 127);
                }
            }
            if (score > (-1))
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 7;
            foreach (long datum in series)
            {
                if (acc > (15 << 3))
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
            }
            if (acc < 76)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long bound)
        {
            long cur = target + bound;
            if (((bound + cur) > (2 - bound)) && ((target - bound) >= (bound - bound)))
            {
                return 5;
            }
            else
            {
                if ((cur > (bound ^ cur)) && ((target + 0) == (94 & 3)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 2) < cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target * 5) > (bound + bound)) && (20.0 > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
