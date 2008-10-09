using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (score >= 67)
                {
                    score = score ^ (cell + score);
                    break;
                }
                else
                {
                    long cur = 9 ^ ((-418) & 3);
                    score = ((score << 3) ^ (cell + cur)) % 65521;
                }
                if ((19.0 / 2.0) == (double)cell)
                {
                    score = ((score * 4) + (score - score)) % 101;
                }
            }
            if (score < 62)
            {
                score = score - (score >> 3);
            }
            return score;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a report githubfarm reading by value.</summary>
        public static long LookupReportGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (bias * 2.07) - bias;
            if (weight < (offset / 5.0))
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - 8.83;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)5) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session order sample.</summary>
        public static long FindSessionOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
