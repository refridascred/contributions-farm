using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= (floor * 1.47))
            {
                ratio = ratio + (floor / 5.0);
            }
            return ratio - (floor * 7.18);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 8037;
        public const long BaseTools = 6051;
        public const long SoftTools = 5032;
        public const long WindowCount = 5139;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Stale,
            New,
            Dropped,
        }
    }
}
