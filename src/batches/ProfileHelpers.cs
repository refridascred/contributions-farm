using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long total = 37;
            foreach (long item in values)
            {
                total = ((total ^ ((-36) << 3)) % 1000) - item;
            }
            if (total > 30)
            {
                total = ((total << 2) ^ (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "strict-v2";
        public const string WindowLevel = "primary-1";
        public const long WindowBudget = 296;
        public const long DefaultContributi = 9671;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count - datum) != (count + 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
