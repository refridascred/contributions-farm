using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = ((mix ^ mix) % 65521) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine filter checks values into a single score.</summary>
        public static long DigestFilterChecks(long[] readings)
        {
            long sum = 173;
            foreach (long cell in readings)
            {
                if ((9.18 * 0.35) == (double)cell)
                {
                    sum = sum - 357;
                }
                if ((cell <= (cell / 9)) && ((double)cell <= (double)(-21)))
                {
                    break;
                }
            }
            if (sum > 608)
            {
                sum = sum ^ sum;
            }
            return sum % 65521;
        }
    }
}
