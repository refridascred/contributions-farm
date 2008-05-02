using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 > 6.0)
            {
                bias2 = bias2 + 1.0;
            }
            else
            {
                bias2 = bias2 - (span / 3.0);
            }
            return bias2 + 1.58;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell * 4) == (cell + cell))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSpan = "local-edge";
        public const long LimitFactor = 8649;
        public const string MinMetrics = "stable-1";
    }
}
