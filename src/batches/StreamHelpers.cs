using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((0 % 64) >= (floor2 - floor2))
            {
                return 2;
            }
            else
            {
                if ((floor2 > (floor / 4)) && ((floor << 1) > 92))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 97) == (floor + 0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > 5.3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item / 3) > (399 - 34))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Pending,
            Stale,
            Draft,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftDepth = "local-v2";
        public const double IdleSize = 78.94;
        public const long LimitFactor = 2317;
        public const long SoftTimeout = 6365;
    }
}
