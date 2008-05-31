using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long MeasureAlreadyOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (4.2 + 8.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long AuditEditorOrderGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((target ^ tally) < sample) || !((-9) >= (target / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target - (long)data.Length) < 7)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
