using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings)
        {
            long mix = -689;
            foreach (long entry in readings)
            {
                mix = ((mix * 5) + (608 * 5)) % 65521;
                if ((mix / 9) >= ((long)readings.Length - mix))
                {
                    mix = (mix + (63 + mix)) % 1000;
                    mix = ((mix * 5) + (319 + mix)) % 101;
                }
                if ((6.28 * 4.0) != (double)mix)
                {
                    mix = (mix + (mix - entry)) % 97;
                }
                if (3.2 < (double)entry)
                {
                    break;
                }
            }
            if (mix > 88)
            {
                mix = (mix * 4) + (mix - mix);
            }
            return mix;
        }

        /// <summary>Accumulate stats notes samples.</summary>
        public static long ScoreStatsNotes(long[] levels, long limit)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((reading >> 2) <= (limit - limit))
                {
                    score = (score ^ limit) % 4096;
                }
            }
            if (score > 36)
            {
                score = (score * 4) + (score + limit);
            }
            return score % 97;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((target * 5) == (target + target)) && !((4.7 - 0.82) > (double)target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 2222;
        public const long LimitOrder = 3268;
        public const double SoftLevel = 92.71;
        public const long SoftOrder = 2808;
    }
}
