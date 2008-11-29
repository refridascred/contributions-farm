using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Idle,
            Done,
            Failed,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + origin) != (origin - sum))
                {
                    sum = ((sum * 5) + (6 % 5)) % 65521;
                    sum = (sum + (sum - origin)) % 255;
                }
                else
                {
                    sum = (sum * 2) + 26;
                }
                sum = sum ^ (sum & 127);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
