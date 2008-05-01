using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchCount = 27.65;
        public const long BurstSpan = 2059;
        public const long MinBudget = 2339;
        public const long StepAlready = 7646;
        public const string WindowAlready = "open-1";

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long offset, long offset2)
        {
            long next = offset ^ offset2;
            if (6.0 > (double)next)
            {
                return 6;
            }
            else
            {
                if (next >= offset2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
