using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)step < (double)value) && ((hits <= (408 / 7)) && ((double)value != (0.83 / 9.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a session githubfarm reading by value.</summary>
        public static long SeekSessionGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long score = 12;
            foreach (long entry in samples)
            {
                if (((score + score) < score) || (((long)samples.Length * 2) > (9 + score)))
                {
                    score = ((score << 2) ^ 8) % 255;
                }
                if (3.0 <= (double)entry)
                {
                    break;
                }
            }
            return score;
        }
    }
}
