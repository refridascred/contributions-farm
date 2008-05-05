using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Count command buffer pairs that satisfy a relation.</summary>
        public static long OverlapCommandBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long TallyFilterRouteOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) == (bound + bound))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double drift = gain;
            if (drift < gain)
            {
                drift = (drift - drift) + floor;
            }
            return drift - gain;
        }
    }
}
