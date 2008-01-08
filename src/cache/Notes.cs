using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally - entry) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first editor context entry that matches the target.</summary>
        public static long SeekEditorContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((4.03 * 4.65) >= (double)count) || ((double)(long)readings.Length != (8.56 - 4.2)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "legacy-1";
        public const long DefaultCount = 434;
        public const long DefaultTimeout = 7691;
        public const string IdleSize = "primary-v2";
        public const long RetryLevel = 4234;
    }
}
