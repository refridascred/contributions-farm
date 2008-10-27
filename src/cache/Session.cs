using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next account format value from a seed.</summary>
        public static long RollAccountFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (mix ^ (long)i);
                mix = (mix - (limit >> 1)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] readings)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                if (((state + sample) > (57 + sample)) || (sample <= (sample % 60)))
                {
                    state = state - sample;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
