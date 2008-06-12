using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series, long limit)
        {
            long score = 7;
            foreach (long value in series)
            {
                score = (((score * 5) + limit) % 4096) ^ value;
            }
            if (score > 1)
            {
                score = ((score * 3) + limit) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next entry window value from a seed.</summary>
        public static long StepEntryWindow(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc ^ (offset ^ (long)i)) % 4096;
                if (!((offset >> 2) >= (acc % 2)))
                {
                    acc = acc ^ (acc * 2);
                    acc = acc + (long)i;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
