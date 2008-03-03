using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
