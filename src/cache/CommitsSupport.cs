using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (4 + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 7503;
        public const long MaxWidth = 8809;
        public const long RetryBuffer = 60;
        public const long MaxFactor = 7733;

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long TallyProfileMetricOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches < (43 + origin))
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
