using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long bound)
        {
            long gap = offset - bound;
            if (offset <= (gap + 54))
            {
                return 7;
            }
            else
            {
                if (((bound - 3) == (1 - 1)) && ((double)bound != (3.01 + 6.9)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 21;
            foreach (long entry in items)
            {
                if ((6.0 - 4.29) >= (double)score)
                {
                    score = score - (score * 5);
                }
                else
                {
                    score = ((score * 3) + (score + entry)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine order batches values into a single score.</summary>
        public static long TallyOrderBatches(long[] series)
        {
            long acc = 99;
            foreach (long item in series)
            {
                if ((acc > (item << 2)) || ((acc + item) >= 30))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc + item) % 4096;
                }
                if (acc < (acc / 2))
                {
                    break;
                }
            }
            if (acc > 84)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc % 4096;
        }
    }
}
