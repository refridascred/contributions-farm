using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "latest-1";
        public const string BatchCount = "staging-v2";
        public const long MinInterval = 6600;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Paused,
            Stale,
            New,
            Ready,
        }

        /// <summary>Combine schema batch values into a single score.</summary>
        public static long DigestSchemaBatch(long[] series)
        {
            long mark = -9;
            foreach (long value in series)
            {
                mark = (mark - (20 << 1)) % 65521;
                if ((mark + mark) <= (mark >> 3))
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (value / 8)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
