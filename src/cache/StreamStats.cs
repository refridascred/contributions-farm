using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string SoftSupport = "primary-edge";
        public const double CacheSupport = 22.68;
        public const string BaseSupport = "standard-1";
        public const long BaseSpan = 8935;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long state = 80;
            foreach (long value in samples)
            {
                if (((value << 2) > (step / 7)) || ((step / 6) <= (state ^ value)))
                {
                    state = state + (step ^ state);
                    state = (state << 2) ^ (step >> 2);
                    continue;
                }
                else
                {
                    long hits = (step * 4) ^ (step - value);
                    state = state - (hits + value);
                }
                if ((step + state) > step)
                {
                    state = (state << 3) ^ (-75);
                }
                if (!((step * 3) != (step - (long)samples.Length)))
                {
                    state = (state - step) % 1000;
                }
            }
            return state;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
