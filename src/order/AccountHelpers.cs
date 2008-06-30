using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine payload channel values into a single score.</summary>
        public static long ScorePayloadChannel(long[] readings, long origin)
        {
            long mix = 442;
            foreach (long sample in readings)
            {
                mix = (((mix << 2) ^ (5 / 5)) % 101) - origin;
                mix = ((mix << 3) ^ (sample + 80)) % 101;
                if ((mix + 441) > (mix / 2))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 2) ^ (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + 7.67) - (double)(long)i;
            }
            return rate + (span + ratio);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Pending,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool GuardToolsMetricsLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
