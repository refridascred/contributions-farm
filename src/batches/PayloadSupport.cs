using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] readings, long bound)
        {
            long mix = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) > (bound / 8)) || ((long)readings.Length <= cell))
                {
                    mix = (mix ^ (85 - cell)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + (bound - bound)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin < (acc + origin))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    break;
                }
                else
                {
                    acc = acc ^ ((long)i + (long)i);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
