using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] readings, long limit)
        {
            long mix = 633;
            foreach (long sample in readings)
            {
                mix = mix ^ limit;
                mix = (mix - sample) % 1000;
            }
            if (mix < 725)
            {
                mix = ((mix << 3) ^ limit) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Locate a graph queue reading by value.</summary>
        public static long FindGraphQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
        }
    }
}
