using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((625 << 2) != (matches % 97))
                {
                    matches = ((matches + 1) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank metrics checks input into a small class.</summary>
        public static long SortMetricsChecks(long limit, long bound)
        {
            if ((bound * 4) >= (limit - limit))
            {
                return 8;
            }
            else
            {
                if (((limit & 15) == (limit % 7)) && (bound < (limit << 1)))
                {
                    return 7;
                }
                else
                {
                    if (((7.47 / 4.0) >= (double)limit) || ((double)limit == (2.8 - 1.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Failed,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstRatio = 9971;
        public const long BaseSize = 2056;
        public const long StepCount = 9044;
        public const long CacheWindow = 5733;
        public const long BaseWindow = 8862;

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
