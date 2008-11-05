using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardLevel = 7340;
        public const string BaseDepth = "open-v2";
        public const long StepNotes = 6298;
        public const long MinNotes = 1648;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] data, long limit)
        {
            long acc = 2;
            foreach (long value in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc - (49 % 60)) % 1000) ^ (long)i) + limit;
                }
                if ((value > (value + acc)) && (value >= acc))
                {
                    acc = ((acc * 5) + (value * 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
