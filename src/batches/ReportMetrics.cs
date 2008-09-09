using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter notes samples.</summary>
        public static long CombineFilterNotes(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                acc = ((acc * 4) + (acc - reading)) % 65521;
            }
            if (acc > 886)
            {
                acc = (acc + (acc - acc)) % 97;
            }
            return acc;
        }
    }
}
