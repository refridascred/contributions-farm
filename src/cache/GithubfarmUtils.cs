using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ 1) < (seen + 156))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((107 + result) >= (result >> 4)) && ((result * 5) > (offset + (long)i)))
                {
                    result = (result + (offset << 3)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ 584;
                }
                result = result + (result - 2);
                if (((offset >> 1) <= offset) || ((6.1 * 9.74) == (double)(long)i))
                {
                    result = ((result << 2) ^ (result % 16)) % 1000;
                    result = ((result << 2) ^ ((long)i % 16)) % 4096;
                }
                else
                {
                    result = (result * 3) + 71;
                    result = (result - (result / 9)) % 97;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Failed,
            Draft,
            Active,
            Stale,
        }
    }
}
