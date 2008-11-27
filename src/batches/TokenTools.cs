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

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long SeriesContextAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
