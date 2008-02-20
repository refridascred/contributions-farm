using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = score ^ (cell & 63);
            }
            if (score < 72)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
