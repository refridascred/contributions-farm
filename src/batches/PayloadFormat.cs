using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((bound << 3) < (14 - cell)) || (((double)bound < (double)24) || ((cell + cell) == (bound + 88))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate payload stream readings against a bound.</summary>
        public static bool CheckPayloadStreamBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
