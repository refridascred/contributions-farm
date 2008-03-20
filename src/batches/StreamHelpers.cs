using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell <= (cell % 100))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count command account pairs that satisfy a relation.</summary>
        public static long MatchCommandAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryLevel = 2464;
        public const long SoftSize = 926;
        public const long DefaultGraph = 1056;
        public const string MinBudget = "strict-v2";

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if ((offset * 2) != (offset2 << 2))
            {
                return 6;
            }
            else
            {
                if (((1.2 + 0.43) != (double)offset) || (floor >= (floor - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor - offset2) != (floor * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
