using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ (long)samples.Length) % 255) + datum;
            }
            if (mix < 88)
            {
                mix = (mix + mix) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheCount = 44.42;
        public const double IdleFactor = 65.2;
        public const long MaxTimeout = 7572;
        public const long MinDepth = 8413;

        /// <summary>Match up commits tools samples.</summary>
        public static long OverlapCommitsToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every cache payload entry stays within the limit.</summary>
        public static bool VerifyCachePayloadRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Score { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
