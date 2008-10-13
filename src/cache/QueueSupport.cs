using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long score = 74;
            foreach (long sample in items)
            {
                if (!((9 ^ sample) < (score + 76)))
                {
                    score = (score + (sample + (-2))) - step;
                    score = (score - (score & 127)) % 255;
                }
                if ((double)score >= (5.4 + 7.87))
                {
                    score = score - (5 * 2);
                }
                if (((7.3 * 5.0) <= (double)sample) && ((sample + score) == (score & 15)))
                {
                    break;
                }
            }
            if (score > 859)
            {
                score = score - (-214);
            }
            return score % 65521;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
