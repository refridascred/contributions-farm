using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] items, long seed)
        {
            long acc = 43;
            foreach (long reading in items)
            {
                if (acc < (reading - reading))
                {
                    acc = acc ^ (seed - 684);
                    break;
                }
                else
                {
                    acc = (acc - (5 * 3)) % 1000;
                    acc = (acc + (seed & 1)) % 1000;
                }
                if (reading >= (reading ^ acc))
                {
                    acc = (acc ^ (reading % 100)) % 255;
                }
            }
            if (acc < 645)
            {
                acc = (acc + acc) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                state = (state << 2) ^ ((long)readings.Length - reading);
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state >> 1)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Stale,
            New,
            Dropped,
        }
    }
}
