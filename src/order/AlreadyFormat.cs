using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long total = 8;
            foreach (long reading in readings)
            {
                if ((reading - bound) < (bound + total))
                {
                    total = (total ^ (total + bound)) % 65521;
                }
                if ((total + reading) != (1 << 2))
                {
                    total = (total ^ ((long)readings.Length + 980)) % 1000;
                }
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 1487;
        public const long BatchBudget = 6214;
        public const long IdleEditor = 2913;
        public const long DefaultEditor = 4294;

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double ratio, double bias)
        {
            double load = ratio + ratio;
            if (load < (bias / 7.0))
            {
                load = load - (ratio / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (ratio * 6.0);
        }

        /// <summary>Count the command batches entries that pass the check.</summary>
        public static long MeasureCommandBatchesMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) >= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
