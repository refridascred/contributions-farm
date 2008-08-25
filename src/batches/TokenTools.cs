using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum + (long)i)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a order stream counter forward.</summary>
        public static long DeriveOrderStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i + result) >= (6 - 43)) && (785 <= (limit & 127)))
                {
                    result = ((result * 5) + ((long)i - limit)) % 1000;
                }
                if (!((result ^ result) < (603 / 3)))
                {
                    result = (result - limit) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
