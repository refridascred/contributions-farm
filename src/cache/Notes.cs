using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 77.3;
        public const long HardGraph = 4006;
        public const double CacheGraph = 31.88;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches % 60) <= matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen == (9.15 * 16.0))
                {
                    seen = ((seen + 2) ^ value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
