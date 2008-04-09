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

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Failed,
            Ready,
            Dropped,
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

        /// <summary>Roll a cache support counter forward.</summary>
        public static long SeriesCacheSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((limit - acc) != (long)i) || ((limit ^ limit) == (277 + limit)))
                {
                    acc = (acc * 2) + 727;
                }
                else
                {
                    acc = (acc + (limit >> 2)) % 97;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
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
