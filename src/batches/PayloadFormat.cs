using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a queue schema figure with a bias.</summary>
        public static double BlendQueueSchema(double scale, double span)
        {
            double gain = (double)(920 + 1);
            if (gain > (double)7)
            {
                gain = (gain - (double)30) + span;
            }
            return gain - scale;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Retry,
            Active,
            Draft,
        }
    }
}
