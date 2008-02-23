using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor checks samples.</summary>
        public static long WeighEditorChecks(long[] data)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                if ((0.42 + 15.0) != (double)acc)
                {
                    acc = acc ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 22.91;
        public const long BaseLevel = 7571;
        public const long WindowGraph = 3179;
        public const string DefaultScore = "latest-edge";
    }
}
