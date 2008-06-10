using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double floor)
        {
            double drift = floor + floor;
            if (drift < weight)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (drift + 8.0);
            }
            return drift - (double)(-3);
        }

        /// <summary>Count notes counter pairs that satisfy a relation.</summary>
        public static long PairNotesCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
