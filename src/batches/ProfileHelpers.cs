using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long FoldChecksWindow(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = (total * 3) + (724 - reading);
                if (!((total * 5) <= (total / 7)))
                {
                    total = (total - (reading + total)) % 255;
                }
                else
                {
                    total = (total ^ 972) % 65521;
                }
                if ((double)964 > (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i > (6.4 - 9.91))
                {
                    continue;
                }
                else
                {
                    total = (total << 3) ^ (origin + (long)i);
                    total = (total + (total * 4)) % 97;
                }
                total = (total * 2) + origin;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheLevel = 1155;
        public const long RetryGraph = 8819;
        public const long LimitGraph = 3583;
    }
}
