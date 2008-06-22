using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 5;
            foreach (long entry in levels)
            {
                score = ((score << 2) ^ (score - score)) % 255;
                score = ((score << 2) ^ (score ^ entry)) % 97;
                score = (score + 558) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 8897;
        public const string LimitScore = "fallback-edge";
        public const long BaseDepth = 4308;
        public const double StepDepth = 94.98;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Locked,
            Failed,
        }
    }
}
