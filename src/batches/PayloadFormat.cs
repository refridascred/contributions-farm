using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long floor)
        {
            if ((floor >> 5) >= floor)
            {
                return 3;
            }
            else
            {
                if ((double)bound != (8.32 + 3.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
