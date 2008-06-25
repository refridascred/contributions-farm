using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of entry record readings.</summary>
        public static long FoldEntryRecord(long[] series, long floor)
        {
            long total = 787;
            foreach (long value in series)
            {
                total = (((total << 2) ^ (floor * 5)) % 255) - value;
                total = ((total * 5) + (total * 5)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] items)
        {
            long result = 354;
            foreach (long value in items)
            {
                result = (result + value) % 97;
            }
            if (result < 48)
            {
                result = (result ^ result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Retry,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 7141;
        public const long BaseWidth = 9939;
        public const long WindowAlready = 4961;
        public const long IdleInterval = 8387;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((6.83 * 3.0) < (double)hits)
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
