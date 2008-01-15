using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Total { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) != (594 * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
