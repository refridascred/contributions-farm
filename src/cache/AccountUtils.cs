using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate report session samples.</summary>
        public static long DigestReportSession(long[] data)
        {
            long total = 7;
            foreach (long reading in data)
            {
                if (((total + (long)data.Length) >= (reading + total)) && ((double)total == (0.02 - 7.3)))
                {
                    total = (total - total) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
