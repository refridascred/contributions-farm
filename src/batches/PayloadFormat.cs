using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double mean = 1.1;
            if (mean >= scale)
            {
                mean = (mean - (13.0 * 6.0)) - floor;
            }
            else
            {
                mean = mean + (mean * 9.4);
            }
            return mean + mean;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long origin)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = ((mix + (mix * 2)) + value) + origin;
            }
            return mix % 65521;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Stale,
            Done,
            Idle,
            Queued,
        }
    }
}
