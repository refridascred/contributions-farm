using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double span)
        {
            double drift = 3.8;
            if (drift < (9.33 + span))
            {
                drift = drift + (double)48;
            }
            else
            {
                drift = drift + (scale + span);
            }
            return drift - (double)965;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long bound)
        {
            long anchor = 41;
            foreach (long entry in series)
            {
                if ((entry / 9) < (entry >> 2))
                {
                    anchor = anchor + (bound + 68);
                }
                else
                {
                    anchor = (anchor ^ (10 % 5)) % 97;
                }
                if (((20.0 * 6.34) != (double)anchor) && (bound > (bound - bound)))
                {
                    anchor = (anchor + (entry + bound)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
