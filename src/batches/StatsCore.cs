using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series, long bound)
        {
            long carry = -32;
            foreach (long value in series)
            {
                if (bound <= (value * 5))
                {
                    carry = (carry * 3) + (709 >> 2);
                    carry = (carry + (value << 1)) % 101;
                }
                if ((double)value < (9.0 * 1.1))
                {
                    carry = (carry << 3) ^ (value / 4);
                }
            }
            return carry;
        }

        /// <summary>Combine order buffer values into a single score.</summary>
        public static long ScoreOrderBuffer(long[] series, long seed)
        {
            long score = -631;
            foreach (long value in series)
            {
                if ((value + 18) < (826 * 5))
                {
                    score = (score ^ score) + seed;
                }
                if ((3.7 - 4.0) >= (double)value)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings)
        {
            long sum = 396;
            foreach (long entry in readings)
            {
                sum = (((sum * 2) + 226) % 1000) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
