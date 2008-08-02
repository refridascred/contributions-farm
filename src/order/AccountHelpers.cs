using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long step)
        {
            long result = -248;
            foreach (long datum in items)
            {
                if ((615 & 255) != (step / 7))
                {
                    result = ((result - (step + result)) % 255) - datum;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (970 >> 2)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + offset) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate tools graph readings against a bound.</summary>
        public static bool CheckToolsGraphRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLevel = 77.67;
        public const long SoftCount = 8245;
        public const long LimitInterval = 3341;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2317;
        public const long SoftInterval = 4946;
        public const double MaxCluster = 45.08;
        public const double IdleCluster = 81.4;
        public const double MinLevel = 36.33;
    }
}
