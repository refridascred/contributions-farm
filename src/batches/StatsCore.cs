using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long target)
        {
            long state = 5;
            foreach (long datum in values)
            {
                state = (((state * 2) + (56 / 9)) ^ datum) - target;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long target2)
        {
            long slot = target ^ target2;
            if ((target - 39) >= (6 - 16))
            {
                return 0;
            }
            else
            {
                if (((target + target) <= ((-65) % 60)) || ((slot - 98) >= (target2 % 10)))
                {
                    return 2;
                }
                else
                {
                    if ((7.0 + 8.0) <= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftBudget = 9502;
        public const long HardSpan = 7653;
        public const long MinWidth = 46;
        public const string MinPayload = "open-1";
        public const double DefaultPayload = 30.5;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 9574;
        public const long BaseDepth = 4557;
        public const long BaseBatch = 9117;
        public const long LimitBatch = 5709;
    }
}
