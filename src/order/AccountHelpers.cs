using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
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
