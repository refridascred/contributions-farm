using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm record samples.</summary>
        public static long CombineGithubfarmRecord(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((score * 5) > datum)
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = (score - (datum - datum)) % 4096;
                    break;
                }
                else
                {
                    score = (score + (score / 2)) % 97;
                }
                score = (score ^ datum) % 97;
                if ((double)datum > (8.78 / 3.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheScore = 4749;
        public const double MaxSize = 24.63;
        public const long SoftCount = 2208;
        public const string WindowSize = "strict-v2";
        public const double CacheNotes = 2.14;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mark = 940;
            foreach (long cell in samples)
            {
                if (((cell << 3) <= (mark - mark)) && ((761 + mark) != (cell - mark)))
                {
                    mark = ((mark * 4) + ((long)samples.Length + mark)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
