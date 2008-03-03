using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of farm filter readings.</summary>
        public static long CompareFarmFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6349;
        public const long BasePayload = 9247;
        public const string MaxLevel = "strict";
        public const long WindowLevel = 5922;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 3244;
        public const long CacheTools = 5697;
        public const double BatchWidth = 77.93;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen - offset) > cell) && ((0.61 - 4.97) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
