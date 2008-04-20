using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowWidth = 6456;
        public const string LimitDepth = "standard-1";
        public const string LimitSpan = "cached-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleSpan = 67.25;
        public const double SoftContributi = 70.45;
        public const long BaseContributi = 1476;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long limit, long step)
        {
            long next = limit ^ step;
            if ((next >> 3) < next)
            {
                return 1;
            }
            else
            {
                if ((double)next <= (8.07 - 5.5))
                {
                    return 4;
                }
                else
                {
                    if (((607 % 60) > (next + next)) && (9.3 <= (double)next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 3) ^ (mix + step)) % 1000) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Draft,
            Paused,
        }
    }
}
