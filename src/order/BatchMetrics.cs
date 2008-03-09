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

        /// <summary>Fold a list of window filter readings.</summary>
        public static long FoldWindowFilter(long[] readings)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                if (!((46 - reading) >= total))
                {
                    total = total + (reading / 7);
                }
            }
            if (total > 621)
            {
                total = (total + (total - (long)readings.Length)) % 101;
            }
            return total % 97;
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

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7858;
        public const long IdleContext = 7191;
        public const long LimitContext = 7433;
    }
}
