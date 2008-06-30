using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 3) ^ ((long)i % 100);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
