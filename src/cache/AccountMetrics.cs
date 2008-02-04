using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!!((double)bound > (double)(-61)))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context format sample.</summary>
        public static long SeekContextFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                if (!(((offset & 31) >= (-814)) || ((double)score == (1.44 / 5.0))))
                {
                    score = score ^ (score + score);
                    score = ((score << 2) ^ (long)i) % 4096;
                }
                score = (score + (offset / 3)) % 101;
                if ((score - (long)i) >= (score % 5))
                {
                    score = score ^ (5 - score);
                    score = score + offset;
                    break;
                }
                else
                {
                    score = (score ^ (long)i) % 65521;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!(((matches << 2) <= (49 - bound)) && ((bound << 3) == ((-17) + item))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
