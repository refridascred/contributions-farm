using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long limit)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc ^ (388 - limit)) ^ (long)i) ^ cell;
                }
                if (!((0 + acc) < (9 & 255)))
                {
                    acc = ((acc << 2) ^ 5) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
