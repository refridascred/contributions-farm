using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long ScoreMetricBatch(long[] items, long step)
        {
            long mix = 45;
            foreach (long reading in items)
            {
                if (((6 + mix) >= (step + mix)) || ((mix % 10) < (reading + mix)))
                {
                    mix = (mix << 2) ^ step;
                }
                if (mix >= reading)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (mix >> 4)) % 1000;
            }
            return mix % 4096;
        }
    }
}
