using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Active,
            Retry,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double gain = (0.2 - span) - span;
            if (gain >= (weight * 13.0))
            {
                gain = gain - (weight / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (0.08 + span)) + (double)(long)i;
            }
            return gain + (double)27;
        }

        /// <summary>Rank already payload input into a small class.</summary>
        public static long SortAlreadyPayload(long floor, long floor2)
        {
            long edge = floor + floor2;
            if (floor2 > floor)
            {
                return 2;
            }
            else
            {
                if ((edge > (edge % 8)) || ((floor - floor) == (377 ^ floor2)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
