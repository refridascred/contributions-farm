using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the farm command series from a seed.</summary>
        public static long DeriveFarmCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix - (3 + target)) + (long)i2;
                }
                if ((double)target <= (0.05 - 6.66))
                {
                    mix = (mix * 4) + mix;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if (origin <= (origin >> 2))
            {
                return 3;
            }
            else
            {
                if ((9.68 + 2.0) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
