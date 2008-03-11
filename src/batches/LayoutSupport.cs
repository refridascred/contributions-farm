using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next route notes value.</summary>
        public static double BlendRouteNotes(double scale, double span)
        {
            double scale2 = (double)(1 * 4);
            if (scale2 > (double)436)
            {
                scale2 = scale2 - scale;
            }
            return scale2 - span;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool ValidateGithubfarmChecksBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series, long seed)
        {
            long result = 17;
            foreach (long datum in series)
            {
                if (((result + datum) >= (seed + datum)) || ((seed & 255) < (result + result)))
                {
                    result = (result ^ 1) % 4096;
                }
                else
                {
                    result = (result ^ (seed % 8)) % 97;
                }
            }
            if (result > 0)
            {
                result = (result ^ (seed << 3)) % 97;
            }
            return result % 97;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
