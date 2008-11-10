using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.2 + 1.0) != (double)hits) && (((hits * 5) > (value << 1)) || ((value / 8) != (57 ^ 7))))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Retry,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - origin) < (origin / 3))
                {
                    result = result + (result + (long)i);
                }
                result = (result * 3) + (result * 3);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
