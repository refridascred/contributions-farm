using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitInterval = 2.68;
        public const long MinBudget = 2108;
        public const long BaseSpan = 7398;
        public const string DefaultAlready = "standard-1";
        public const string SoftAlready = "open";

        /// <summary>Count token schema pairs that satisfy a relation.</summary>
        public static long CompareTokenSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long anchor = 977;
            foreach (long cell in readings)
            {
                anchor = anchor - (anchor + cell);
            }
            if (anchor < 3)
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Digest a series of batches support entries.</summary>
        public static long ScoreBatchesSupport(long[] readings, long origin)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                carry = carry - (cell - carry);
                carry = carry + (origin + origin);
            }
            return carry % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
