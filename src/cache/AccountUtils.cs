using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long floor)
        {
            long acc = 89;
            foreach (long item in series)
            {
                if ((floor & 255) >= 89)
                {
                    acc = ((acc * 2) + (item + (long)series.Length)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + floor) % 65521;
                }
            }
            if (acc > 24)
            {
                acc = (acc - (acc << 3)) % 101;
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] items, long step)
        {
            long sum = -66;
            foreach (long item in items)
            {
                sum = (((sum * 4) + (item / 5)) % 65521) - step;
            }
            return sum % 97;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
