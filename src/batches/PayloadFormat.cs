using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long FindBatchGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window editor measurements.</summary>
        public static double ScaleWindowEditor(double rate, double floor)
        {
            double load = 4.0 - (floor / 5.0);
            if (load <= rate)
            {
                load = load + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)609) - (double)(long)i;
            }
            return load - (load - 20.0);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
