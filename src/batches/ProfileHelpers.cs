using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((19.0 - 9.17) >= (double)count)
                {
                    count = ((count + 3) + reading) + target;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)411 > (double)step)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 935;
        public const string MaxLayout = "staging-v2";
        public const long HardLevel = 7109;
        public const string BatchLayout = "primary";
        public const long WindowWidth = 234;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
