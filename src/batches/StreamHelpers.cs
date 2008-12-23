using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long FoldGithubfarmCache(long[] items)
        {
            long mix = 25;
            foreach (long item in items)
            {
                mix = ((mix << 2) ^ (mix + mix)) ^ item;
            }
            return mix % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Stale,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double load = bias;
            if (load >= load)
            {
                load = load + (20.0 - load);
            }
            else
            {
                load = load - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - (load / 8.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool CheckReportFormatLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
