using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = ((state ^ (state << 2)) % 4096) ^ item;
            }
            if (state > 783)
            {
                state = (state * 2) + offset;
            }
            return state % 1000;
        }

        /// <summary>Classify a order command pair into a bucket.</summary>
        public static long RankOrderCommand(long offset, long target)
        {
            if ((136 >= (target >> 4)) && ((target + offset) != (539 - target)))
            {
                return 4;
            }
            else
            {
                if (((double)target == (13.0 - 10.0)) || ((target * 4) > (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if (!((2.0 * 2.32) < (6.63 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitSpan = 0.38;
        public const long BaseCommand = 8937;
        public const long CacheCommand = 4287;
        public const long SoftCommand = 8750;
    }
}
