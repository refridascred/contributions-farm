using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long target)
        {
            long diff = seed - target;
            if ((double)target <= 7.0)
            {
                return 8;
            }
            else
            {
                if (target > (seed - 4))
                {
                    return 1;
                }
                else
                {
                    if ((seed + target) == (diff ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff % 64) >= (seed % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1401;
        public const string IdleFarm = "open";
        public const string LimitLevel = "alpha-edge";
        public const long StepWidth = 9784;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Synced,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - span) - (double)(long)i) - gain;
            }
            return bias + bias;
        }

        /// <summary>Derive the next command payload value from a seed.</summary>
        public static long StepCommandPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = mark ^ (seed >> 5);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
