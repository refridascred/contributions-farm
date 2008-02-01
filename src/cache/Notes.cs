using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((offset < (matches + (long)readings.Length)) || !((offset / 4) > (63 / 2)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 9975;
        public const double IdleFilter = 13.29;
        public const long LimitRatio = 3240;
        public const string RetryFilter = "fallback-edge";

        /// <summary>Fold a list of farm editor readings.</summary>
        public static long TotalFarmEditor(long[] items)
        {
            long mix = -124;
            foreach (long datum in items)
            {
                if (((mix + mix) >= (datum / 4)) || ((318 - 2) >= mix))
                {
                    mix = ((mix << 3) ^ (3 / 5)) % 65521;
                }
                else
                {
                    mix = mix + (datum ^ datum);
                }
            }
            return mix % 65521;
        }
    }
}
