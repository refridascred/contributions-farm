using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Paused,
            New,
            Done,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double load = (double)5 - (double)23;
            if (load <= (load - floor))
            {
                load = load - (weight + 9.0);
            }
            else
            {
                load = load - (floor / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 3.4) + (double)(long)i;
            }
            return load - (9.1 + load);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Idle,
            Pending,
        }
    }
}
