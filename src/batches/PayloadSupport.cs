using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "local-1";
        public const long CacheSupport = 9671;
        public const string DefaultCount = "open-v2";
        public const long IdleCount = 1175;
        public const long StepWidth = 3695;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((49 >= entry) || !((621 - tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            New,
            Dropped,
            Pending,
            Done,
        }
    }
}
