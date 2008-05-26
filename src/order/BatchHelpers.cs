using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardSpan = 96.81;
        public const long BaseBuffer = 8045;
        public const string WindowBuffer = "legacy-edge";
        public const long LimitTimeout = 4780;
        public const long HardBuffer = 9364;

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long MeasureToolsClusterGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) <= (datum + limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples, long offset)
        {
            long result = 67;
            foreach (long reading in samples)
            {
                result = (result - (reading - result)) % 1000;
                if ((double)offset >= (2.0 - 0.22))
                {
                    result = ((result << 3) ^ (reading + reading)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ result) % 65521;
                }
            }
            return result;
        }
    }
}
