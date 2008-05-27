using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 5088;
        public const long RetryContext = 1409;
        public const long DefaultRatio = 4343;
        public const long IdleScore = 7841;
        public const long IdleTimeout = 4053;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - seen) < (seen << 3)) && ((seen + sample) != (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                anchor = anchor + ((long)series.Length - sample);
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 3) <= (count & 127))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
