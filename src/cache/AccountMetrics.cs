using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 3082;
        public const string SoftGithubfarm = "primary";
        public const long MinInterval = 4349;
        public const double BatchDepth = 14.56;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)73 < (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long origin)
        {
            long sum = 208;
            foreach (long entry in data)
            {
                if ((double)sum != (18.0 - 8.79))
                {
                    sum = (((sum * 2) + (8 % 3)) + entry) - origin;
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 4) + (sum * 2)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
