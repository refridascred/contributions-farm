using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Pending,
            Closed,
            Draft,
            Locked,
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
