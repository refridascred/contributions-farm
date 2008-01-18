using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                result = (result ^ result) + reading;
            }
            return result;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + ((long)i >> 2)) % 1000;
                sum = (sum ^ (long)i) % 4096;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
