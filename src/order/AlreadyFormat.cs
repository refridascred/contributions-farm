using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Paused,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Combine command schema values into a single score.</summary>
        public static long TotalCommandSchema(long[] series)
        {
            long sum = 919;
            foreach (long sample in series)
            {
                if (sample >= (sample >> 5))
                {
                    sum = ((sum * 5) + (sample % 60)) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sample)) % 4096;
                }
                if ((0.7 + 6.6) == (double)sample)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 - offset) + weight;
        }
    }
}
