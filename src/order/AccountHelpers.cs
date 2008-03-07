using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryLevel = 8459;
        public const long StepNotes = 6081;
        public const long BurstNotes = 1699;

        /// <summary>Find the first farm stats entry that matches the target.</summary>
        public static long LocateFarmStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long CountRouteContextOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (origin > (origin ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long seed)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (result * 5) + (seed << 3);
                if (!(cell > (cell >> 4)))
                {
                    result = (result * 5) + (cell / 6);
                }
            }
            if (result > 214)
            {
                result = ((result * 3) + (result + result)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 883;
        public const string BatchBudget = "stable";
        public const string SoftSize = "local-v2";
        public const string BatchGraph = "standard-1";
    }
}
