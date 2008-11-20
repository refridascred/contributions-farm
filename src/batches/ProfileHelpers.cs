using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long LookupFarmSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseTimeout = 98.66;
        public const long StepDepth = 8787;
        public const long BaseQueue = 83;
        public const double MaxWidth = 15.05;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((5 - cell) > (count / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
