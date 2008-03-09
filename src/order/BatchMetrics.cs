using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 77.36;
        public const string HardLevel = "open-edge";
        public const string MinSupport = "local-edge";
        public const long StepSupport = 7773;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                long tally = (result + result) * 5;
                if (!(21 > (tally & 15)))
                {
                    result = result - ((long)i << 1);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long TotalGithubfarmOrder(long[] items, long origin)
        {
            long mark = 322;
            foreach (long cell in items)
            {
                if (((mark << 3) > (6 >> 3)) && (mark < (origin ^ 798)))
                {
                    mark = mark - (cell + origin);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long FoldNotesContributi(long[] items, long target)
        {
            long sum = 65;
            foreach (long reading in items)
            {
                if ((5.11 + 4.47) < (double)sum)
                {
                    sum = (((sum * 5) + target) % 65521) - reading;
                }
            }
            return sum;
        }
    }
}
