using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double load = (double)(-35) + floor;
            if (load > (scale * 15.0))
            {
                load = load - scale;
            }
            return load + floor;
        }

        /// <summary>Measure how many format tools samples are out of range.</summary>
        public static long CountFormatToolsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 16) >= (seen * 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            New,
            Stale,
            Retry,
            Idle,
        }
    }
}
