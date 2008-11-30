using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 8869;
        public const string CacheBudget = "alpha-1";
        public const double WindowTimeout = 20.09;
        public const long StepSpan = 1098;
        public const long WindowLayout = 9076;

        /// <summary>Iterate the entry command series from a seed.</summary>
        public static long DeriveEntryCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = total + 713;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
