using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                if ((mix ^ (-1)) >= reading)
                {
                    mix = ((mix * 5) + reading) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc ^ (137 + acc)) % 255) ^ (long)i2;
                }
                acc = acc + (seed ^ acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(((value * 3) != (value & 255)) && ((13 / 8) > tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
