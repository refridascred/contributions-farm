using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = ((acc - (acc & 3)) % 97) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >= tally) && ((tally >> 5) < value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
