using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            New,
            Locked,
            Paused,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (!(reading >= floor))
                {
                    anchor = (anchor * 5) + (445 - reading);
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor ^ (19 >> 4)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double AdjustFarmCluster(double scale, double offset)
        {
            double weight = (double)434 * 8.0;
            if (weight > (5.4 / 3.0))
            {
                weight = (weight - (scale + weight)) - offset;
            }
            return weight - (scale + scale);
        }
    }
}
