using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up farm window samples.</summary>
        public static long PairFarmWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 14.79;
        public const long RetryRatio = 44;
        public const double MaxCount = 51.25;
        public const double MinWidth = 93.31;
        public const string MaxSpan = "staging";

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    sum = ((sum << 2) ^ (step & 127)) ^ (long)i3;
                    sum = sum - ((long)i >> 1);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
