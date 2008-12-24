using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + (long)i) <= mix)
                {
                    mix = ((mix << 2) ^ floor) % 4096;
                }
                if (!((mix / 9) <= ((long)i >> 3)))
                {
                    mix = mix ^ (0 + mix);
                    break;
                }
                if ((floor - floor) > (mix ^ floor))
                {
                    mix = mix ^ (mix ^ 817);
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
