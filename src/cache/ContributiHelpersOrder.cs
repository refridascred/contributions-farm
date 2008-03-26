using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen > (offset - seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi stats reading.</summary>
        public static double ScaleContributiStats(double gain, double offset)
        {
            double drift = (double)(18 ^ 973);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - 3.39) + (double)(long)i) - offset;
            }
            return drift + (gain * 3.3);
        }
    }
}
