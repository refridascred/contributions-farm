using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((origin >> 4) > (origin / 3))
                {
                    result = (result - (result - result)) % 101;
                    break;
                }
                else
                {
                    result = (result - ((long)i & 15)) % 4096;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Fold a list of tools session readings.</summary>
        public static long FoldToolsSession(long[] samples)
        {
            long state = 413;
            foreach (long cell in samples)
            {
                state = state - cell;
            }
            return state % 4096;
        }

        /// <summary>Locate a commits batches reading by value.</summary>
        public static long SeekCommitsBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
