using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context stream samples.</summary>
        public static long PairContextStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
