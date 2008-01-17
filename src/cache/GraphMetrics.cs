using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.53;
        public const long MinSchema = 3949;
        public const long StepSchema = 1384;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally > (double)bound)
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long origin)
        {
            long slot = floor - origin;
            if ((14.0 - 13.0) < (0.3 - 1.58))
            {
                return 7;
            }
            else
            {
                if (((8 << 1) <= (floor % 3)) && ((double)slot < (3.5 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (origin & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
