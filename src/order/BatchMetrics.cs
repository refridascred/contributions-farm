using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((6.1 / 8.0) < (double)datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double offset)
        {
            double drift = (scale - offset) - offset;
            if (drift > (drift / 3.0))
            {
                drift = drift + (drift - drift);
            }
            else
            {
                drift = drift + (offset + 5.1);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (offset + scale)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 623;
        public const string IdleSchema = "primary-1";
        public const long IdleSpan = 2398;
        public const string SoftSchema = "cached";
        public const long CacheSchema = 3775;

        /// <summary>Check that every commits schema entry stays within the limit.</summary>
        public static bool ValidateCommitsSchemaBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the editor payload series from a seed.</summary>
        public static long IterateEditorPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
