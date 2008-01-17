using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every session buffer entry stays within the limit.</summary>
        public static bool CheckSessionBufferLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = ((total ^ (total / 4)) % 255) ^ (long)i2;
                }
                if ((6.1 + 8.6) <= (double)total)
                {
                    total = total + (total >> 2);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values, long seed)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                sum = ((sum + (39 + seed)) % 65521) + cell;
                sum = (sum * 2) + (sum ^ sum);
            }
            return sum;
        }
    }
}
