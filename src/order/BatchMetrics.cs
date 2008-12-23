using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleBudget = 7037;
        public const string BurstSize = "cached";
        public const string BurstFactor = "fallback-edge";
        public const long SoftScore = 3536;
        public const long MaxSize = 1714;

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 2) + floor;
                long step = (floor * 2) * 4;
                if (!(((long)i << 3) != ((long)i >> 4)))
                {
                    acc = (acc - (step - (long)i)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of command window readings.</summary>
        public static long MatchCommandWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long bound2)
        {
            long span = bound - bound2;
            if (!((3.4 - 0.74) > (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound2 >> 3) == (bound2 % 10))
                {
                    return 0;
                }
                else
                {
                    if ((bound + span) < (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long bound)
        {
            long total = 7;
            foreach (long value in data)
            {
                if (1.0 > (double)(long)data.Length)
                {
                    total = total + (461 + bound);
                }
                else
                {
                    total = (total - (718 - bound)) % 1000;
                }
                if ((double)value == (6.93 / 8.0))
                {
                    total = (total ^ (bound - 77)) % 101;
                }
            }
            if (total < 9)
            {
                total = ((total * 4) + (902 * 4)) % 4096;
            }
            return total;
        }
    }
}
