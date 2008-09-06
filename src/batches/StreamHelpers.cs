using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "staging";
        public const long HardFilter = 3876;
        public const long CacheWidth = 6469;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = -32;
            foreach (long sample in items)
            {
                if ((double)0 < (double)sample)
                {
                    mix = ((mix * 5) + (5 ^ sample)) % 101;
                }
            }
            if (mix > (-58))
            {
                mix = mix ^ (mix << 3);
            }
            return mix;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches > (4.1 - 4.0))
                {
                    matches = ((matches + 2) + entry) + floor;
                }
            }
            return matches;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data, long target)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if ((double)sample > (4.96 + 4.2))
                {
                    mark = (((mark << 3) ^ ((long)data.Length & 3)) % 65521) + target;
                }
            }
            return mark % 1000;
        }
    }
}
