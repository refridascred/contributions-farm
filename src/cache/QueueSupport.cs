using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a buffer route reading.</summary>
        public static double BlendBufferRoute(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (20.0 * 15.0))
            {
                gain2 = gain2 - (span - gain2);
            }
            return gain2 - 2.4;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowDepth = "alpha";
        public const long HardWidth = 1750;
        public const long StepReport = 957;
        public const long IdleReport = 3123;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
