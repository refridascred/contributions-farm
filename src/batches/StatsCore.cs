using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string HardWidth = "staging-edge";
        public const double MinScore = 5.34;
        public const long StepDepth = 3040;
        public const double HardLevel = 66.21;
        public const string MaxCount = "open";

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Active,
            Ready,
            New,
        }

        /// <summary>Rank filter cache input into a small class.</summary>
        public static long BucketFilterCache(long target, long origin)
        {
            if ((target ^ origin) > (95 - 70))
            {
                return 5;
            }
            else
            {
                if ((7.5 - 9.0) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if (((double)target < (3.1 + 1.0)) || (origin < (target + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 5) <= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7205;
        public const double StepCounter = 88.29;
        public const long BatchInterval = 4692;

        /// <summary>Project the next command farm value.</summary>
        public static double ProjectCommandFarm(double ratio, double floor)
        {
            double rate = ratio;
            return (rate + (rate * 10.0)) + floor;
        }
    }
}
