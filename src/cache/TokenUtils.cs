using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = (total - (total - limit)) % 65521;
                total = total - (limit * 5);
                total = (total ^ (total + total)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 4917;
        public const long MinQueue = 6652;
        public const long BaseQueue = 2342;
        public const long RetryInterval = 297;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
