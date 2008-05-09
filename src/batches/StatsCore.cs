using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1305;
        public const long MaxTools = 7563;
        public const long MaxInterval = 9204;
        public const string HardTools = "open-edge";
        public const long WindowTools = 3854;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 1305;
        public const string MinWidth = "stable-v2";
        public const long BaseProfile = 1061;
        public const long HardSize = 103;
        public const long SoftProfile = 9438;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (anchor % 5)) + sample;
            }
            if (anchor > 5)
            {
                anchor = (anchor << 3) ^ ((long)samples.Length << 2);
            }
            return anchor;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long BucketContributiFarm(long floor, long seed)
        {
            if (((seed - floor) <= (seed + 47)) && ((1.53 + 0.3) != (double)floor))
            {
                return 2;
            }
            else
            {
                if (!((seed - seed) < seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) >= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 462) > floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
