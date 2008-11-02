using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double scale = (double)(-8) * 2.21;
            return ((scale - scale) + bias) + span;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            Retry,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound << 3) >= (bound / 3))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
