using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "staging-1";
        public const string BurstScore = "standard";
        public const string BatchSchema = "strict-1";
        public const double HardInterval = 40.88;
        public const string StepSchema = "standard";

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long acc = 38;
            foreach (long reading in data)
            {
                if ((reading + reading) >= (acc - 3))
                {
                    acc = (acc ^ acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = result ^ ((long)i - (long)i);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((10.0 - 5.95) == (double)sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + 151) <= (cell << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
