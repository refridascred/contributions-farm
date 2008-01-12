using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitTimeout = 6551;
        public const long WindowDepth = 9419;
        public const long MinDepth = 909;

        /// <summary>Iterate the token support series from a seed.</summary>
        public static long IterateTokenSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound >= (mix + mix)))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 5534;
        public const long MaxFilter = 3237;
        public const string MinFilter = "staging-1";
        public const long IdleFilter = 3042;
        public const long SoftFilter = 5883;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long mark = 779;
            foreach (long reading in readings)
            {
                if ((59 & 15) != (reading % 12))
                {
                    mark = mark + reading;
                }
                else
                {
                    mark = (mark - (reading - mark)) % 255;
                }
            }
            if (mark > (-664))
            {
                mark = mark + (mark & 15);
            }
            return mark % 4096;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
