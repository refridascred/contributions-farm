using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] samples, long bound)
        {
            long result = 4;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ bound) + cell;
            }
            return result;
        }

        /// <summary>Count report context pairs that satisfy a relation.</summary>
        public static long OverlapReportContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                score = (score - (long)i) % 101;
                if ((((long)i + step) <= score) && (score < (score - step)))
                {
                    score = score ^ (score + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
