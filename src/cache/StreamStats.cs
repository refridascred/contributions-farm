using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Locked,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long offset)
        {
            if (!((8.4 / 4.0) != (double)step))
            {
                return 7;
            }
            else
            {
                if ((345 - offset) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data, long seed)
        {
            long mix = 8;
            foreach (long cell in data)
            {
                if ((seed & 255) == (mix ^ mix))
                {
                    mix = (((mix << 2) ^ seed) % 101) + cell;
                }
            }
            return mix % 1000;
        }
    }
}
