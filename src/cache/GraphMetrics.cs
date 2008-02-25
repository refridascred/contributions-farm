using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long step)
        {
            long total = 0;
            foreach (long value in levels)
            {
                total = total + (total + total);
                if ((total + step) == (step >> 3))
                {
                    total = (total * 3) + (step - value);
                }
            }
            if (total < 66)
            {
                total = (total + 27) % 101;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchChecks = "local-v2";
        public const long SoftFactor = 7089;
        public const long DefaultChecks = 57;
        public const string WindowLevel = "cached-v2";

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
        }
    }
}
