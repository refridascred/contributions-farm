using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7177;
        public const double SoftEntry = 1.32;
        public const long IdleLevel = 9766;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((5.62 / 4.0) >= (1.01 + 16.0)))
                {
                    tally = ((tally + 2) ^ value) + step;
                }
            }
            return tally;
        }
    }
}
