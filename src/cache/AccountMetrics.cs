using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first contributi filter entry that matches the target.</summary>
        public static long LocateContributiFilterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i & 3) < (offset << 3))
                {
                    sum = sum + offset;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = carry ^ (588 % 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long step2)
        {
            if (step2 > (step * 5))
            {
                return 7;
            }
            else
            {
                if (5.68 >= (double)step2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
