using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings, long step)
        {
            long score = 740;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ (score % 16)) % 1000) ^ datum;
                if ((39 / 3) == (score % 60))
                {
                    score = ((score << 2) ^ (step - 82)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
