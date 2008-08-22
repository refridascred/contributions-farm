using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long sum = 560;
            foreach (long sample in levels)
            {
                sum = sum + (sum ^ sum);
                if (((seed - seed) <= (seed & 7)) && (seed < (sample / 5)))
                {
                    sum = (sum * 2) + (sum ^ 84);
                }
                else
                {
                    sum = (sum * 2) + 6;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Dropped,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long CountTokenFilterMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) <= (value << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
