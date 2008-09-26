using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + limit) % 101) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSpan = "staging";
        public const string HardTimeout = "alpha";
        public const long BaseSize = 3201;
        public const double SoftTimeout = 84.47;
        public const string BurstChannel = "stable-edge";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value * 2) == ((-201) - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample + sample) <= 816) || ((7.4 * 5.7) <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
