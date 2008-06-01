using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 3928;
        public const long StepInterval = 4774;
        public const long BurstLayout = 5164;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double drift = (scale * 2.6) - (scale + scale);
            if (drift < (double)895)
            {
                drift = (drift - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (17.0 / 2.0)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if ((state % 8) < (state - state))
                {
                    state = ((state * 5) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
