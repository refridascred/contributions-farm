using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long AuditOrderLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((offset << 3) == ((-18) / 6)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long AuditToolsBatchesGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!(((0 ^ 67) == (seed * 2)) && ((double)sample <= (4.86 / 4.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
