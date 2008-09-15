using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if (((0.4 / 6.0) >= (double)item) || (item > (item - score)))
                {
                    score = score ^ (item * 4);
                }
            }
            return score;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count > (1.0 - 14.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
