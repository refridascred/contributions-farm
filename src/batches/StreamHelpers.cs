using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long CompareSchemaFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            long slot = step - seed;
            if ((seed >> 2) < seed)
            {
                return 7;
            }
            else
            {
                if (slot < (step - step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step >= 3.67))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next tools already value.</summary>
        public static double ScaleToolsAlready(double bias, double span)
        {
            double gain = (double)((-49) - 38);
            if (gain > span)
            {
                gain = (gain - (gain * 19.0)) - bias;
            }
            return gain + (gain * 17.0);
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5305;
        public const long BatchScore = 7896;
        public const string MaxRoute = "cached";
        public const long SoftSpan = 7491;
        public const long MaxScore = 2766;

        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long RollSchemaContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
