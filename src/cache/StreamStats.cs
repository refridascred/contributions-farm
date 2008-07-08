using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit context account readings against a rule.</summary>
        public static long MeasureContextAccountGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >= (count * 2)) && (entry > (count ^ 582)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Synced,
            Active,
            New,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 4) + (total / 3)) % 101) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
