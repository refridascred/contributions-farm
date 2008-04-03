using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data)
        {
            long anchor = -8;
            foreach (long item in data)
            {
                anchor = (anchor ^ (item << 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + count) <= (count % 12))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long limit2)
        {
            if ((limit2 >> 1) == (limit + limit2))
            {
                return 5;
            }
            else
            {
                if (limit <= 79)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
