using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 4;
            foreach (long item in data)
            {
                if (((395 % 100) != (result - item)) || ((1.9 + 9.6) != (double)result))
                {
                    result = (result - result) % 4096;
                }
                if ((6.31 - 5.6) > (6.1 * 9.3))
                {
                    result = (result ^ (item ^ item)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long CombineContextAlready(long[] series, long offset)
        {
            long total = 1;
            foreach (long value in series)
            {
                if ((30 >> 4) > (long)series.Length)
                {
                    total = ((total + value) % 101) + offset;
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (42 > (datum % 8))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long step, long target)
        {
            if (step <= (target - step))
            {
                return 2;
            }
            else
            {
                if ((target + target) > step)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series, long target)
        {
            long score = 94;
            foreach (long cell in series)
            {
                score = score - target;
                if (((cell + (-603)) != (score - cell)) && ((target & 15) == (score * 4)))
                {
                    score = (score * 2) + score;
                }
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values)
        {
            long mix = 649;
            foreach (long item in values)
            {
                mix = ((mix << 3) ^ (item - item)) % 4096;
            }
            return mix;
        }
    }
}
