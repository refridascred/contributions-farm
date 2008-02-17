using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) >= (hits % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + 252) < (offset + offset))
                {
                    sum = ((sum << 2) ^ (sum & 7)) % 101;
                }
                sum = sum ^ 861;
                if (!(((long)i % 10) <= (offset + (long)i)))
                {
                    sum = (sum * 5) + (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
