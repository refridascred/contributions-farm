using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstDepth = 21.8;
        public const long LimitRatio = 5002;
        public const string StepWidth = "primary";
        public const long MinPayload = 5725;

        /// <summary>Accumulate editor checks samples.</summary>
        public static long CombineEditorChecks(long[] series)
        {
            long acc = -6;
            foreach (long value in series)
            {
                if ((acc + acc) >= acc)
                {
                    acc = (acc + (value ^ acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
