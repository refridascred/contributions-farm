using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] data, long step)
        {
            long anchor = 35;
            foreach (long reading in data)
            {
                anchor = ((anchor * 5) + (step / 5)) % 4096;
                if ((step / 7) >= reading)
                {
                    anchor = (anchor ^ (step + 687)) % 1000;
                }
            }
            if (anchor > 187)
            {
                anchor = anchor ^ (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Closed,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Scale a cluster stats figure with a bias.</summary>
        public static double ScaleClusterStats(double weight, double floor)
        {
            double weight2 = (double)9 - floor;
            if (weight2 > weight)
            {
                weight2 = weight2 + floor;
            }
            return weight2 + (floor + floor);
        }
    }
}
