using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Synced,
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = 19;
            foreach (long value in samples)
            {
                mix = mix + value;
            }
            return mix % 4096;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double offset)
        {
            double ratio = (gain * 13.0) / 7.0;
            return (ratio - ratio) + offset;
        }
    }
}
