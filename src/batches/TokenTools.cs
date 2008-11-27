using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) <= (limit * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 8;
            foreach (long reading in series)
            {
                if (((double)reading <= (7.1 + 9.0)) || ((total + reading) > (reading + total)))
                {
                    total = (total + (169 ^ reading)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
