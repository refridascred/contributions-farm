using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Pending,
            New,
            Ready,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryLevel = 1402;
        public const long BaseStream = 1513;
        public const long MinSize = 6756;
        public const long WindowCount = 5823;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 24) <= (tally * 3))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
