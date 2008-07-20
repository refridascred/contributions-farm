using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long DigestAccountGraph(long[] series)
        {
            long mix = 0;
            foreach (long entry in series)
            {
                if (!(mix > entry))
                {
                    mix = (mix + entry) % 97;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double rate, double floor)
        {
            double load = rate + (double)51;
            if (load < 6.0)
            {
                load = (load + (double)(-78)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (load / 4.0);
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Ready,
            Queued,
            Dropped,
            Done,
        }
    }
}
