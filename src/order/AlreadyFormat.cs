using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((target << 1) >= (reading - target)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long limit)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if (!(7.1 >= (double)limit))
                {
                    sum = ((sum + (sum - limit)) % 65521) ^ value;
                }
            }
            if (sum > 45)
            {
                sum = sum ^ (limit << 1);
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7969;
        public const long CacheSize = 378;
        public const string DefaultTools = "cached";
        public const string LimitLevel = "primary-1";
        public const long MinFactor = 183;

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
