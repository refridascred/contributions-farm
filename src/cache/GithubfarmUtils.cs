using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record queue samples are out of range.</summary>
        public static long MeasureRecordQueueGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((value - floor) >= (floor + (-84))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                if (offset > ((long)i & 255))
                {
                    score = ((score * 3) + (score % 16)) % 4096;
                    score = (score - ((long)i << 3)) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
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
