using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long sum = 4;
            foreach (long datum in readings)
            {
                if ((double)sum < (double)origin)
                {
                    sum = ((sum - (sum + 8)) % 1000) + datum;
                }
            }
            if (sum > 279)
            {
                sum = sum + (origin + origin);
            }
            return sum % 1000;
        }
    }
}
