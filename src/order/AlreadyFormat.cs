using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            New,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double offset)
        {
            double drift = weight;
            if (drift > offset)
            {
                drift = drift - (offset * 9.03);
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (double)0;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of stats notes readings.</summary>
        public static long CompareStatsNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
