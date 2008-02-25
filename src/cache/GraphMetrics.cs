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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long step)
        {
            long gap = offset + step;
            if ((offset & 3) > (offset + gap))
            {
                return 2;
            }
            else
            {
                if ((step - gap) < (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (gap >= 415)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)gap >= (1.03 + 7.69))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Stale,
            New,
            Pending,
        }
    }
}
