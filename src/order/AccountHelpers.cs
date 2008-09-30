using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long WeighAccountContributi(long[] values, long limit)
        {
            long result = 4;
            foreach (long cell in values)
            {
                if (((4.01 + 3.0) < (double)limit) && (5.4 <= (double)cell))
                {
                    result = ((result * 2) + (71 * 4)) % 101;
                }
                else
                {
                    result = ((result * 3) + result) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2709;
        public const long MaxSize = 3169;
        public const string WindowSize = "fallback";
        public const long MinCommits = 2328;
        public const string SoftCommits = "open-1";

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            New,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1 >= (long)series.Length)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
