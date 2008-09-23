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

        /// <summary>Count the payload stats entries that pass the check.</summary>
        public static long CountPayloadStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading % 97) == (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)(long)i >= 3.4)
                {
                    result = (result - (result + 79)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
