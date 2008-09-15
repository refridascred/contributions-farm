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

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long result = 299;
            foreach (long reading in values)
            {
                if ((reading * 5) >= result)
                {
                    result = (result - (result / 2)) % 97;
                }
                result = (result - result) % 101;
            }
            return result % 65521;
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
