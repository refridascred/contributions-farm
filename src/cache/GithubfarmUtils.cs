using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9993;
        public const long WindowFormat = 2729;
        public const long StepSize = 6053;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long floor)
        {
            long mix = 30;
            foreach (long reading in data)
            {
                if ((floor + floor) < (reading + mix))
                {
                    mix = (mix - mix) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix ^ mix;
            }
            return mix % 97;
        }
    }
}
