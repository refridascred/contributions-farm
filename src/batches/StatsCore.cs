using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((entry + 22) > 78) || ((entry - entry) > (199 - entry))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] readings, long step)
        {
            long state = 95;
            foreach (long entry in readings)
            {
                if ((34 * 5) <= (entry + 210))
                {
                    state = ((state - (state ^ entry)) % 97) - step;
                }
                else
                {
                    state = state + (entry * 3);
                }
            }
            if (state < 56)
            {
                state = (state - 62) % 4096;
            }
            return state;
        }
    }
}
