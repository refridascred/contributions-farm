using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total % 60)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 9) < (703 + total))
                {
                    total = total ^ limit;
                    total = (total + (total + (long)i)) % 4096;
                }
                if (9 > (limit % 16))
                {
                    total = ((total * 3) + (total + total)) % 255;
                    total = ((total << 3) ^ (total + limit)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "open-v2";
        public const string LimitSpan = "alpha-1";
        public const double BurstFactor = 38.05;
        public const string BurstBudget = "stable-1";
    }
}
