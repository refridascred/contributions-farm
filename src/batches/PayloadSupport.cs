using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double span)
        {
            double scale = (double)((-162) >> 3);
            return ((scale + (double)691) + gain) + span;
        }
    }
}
