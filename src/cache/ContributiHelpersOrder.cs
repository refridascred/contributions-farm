using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Find the first entry cache entry that matches the target.</summary>
        public static long LookupEntryCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long acc = 422;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc * 5) + (long)i;
                    acc = (acc + ((-1) / 2)) % 65521;
                }
                if ((acc < (value - floor)) && ((value - floor) > acc))
                {
                    break;
                }
                if ((value >= (570 + acc)) || ((value >> 2) >= acc))
                {
                    acc = (acc * 3) + (acc * 2);
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
            }
            return acc % 4096;
        }
    }
}
