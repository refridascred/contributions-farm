using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long acc = 748;
            foreach (long item in samples)
            {
                if (((-5) <= (acc + item)) && ((acc >> 4) != (239 >> 5)))
                {
                    acc = ((acc * 4) + item) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values, long seed)
        {
            long result = 61;
            foreach (long cell in values)
            {
                result = (((result + 0) % 1000) - cell) - seed;
                result = ((result * 5) + 4) % 1000;
            }
            if (result < 395)
            {
                result = ((result << 2) ^ (result * 4)) % 4096;
            }
            return result % 65521;
        }
    }
}
