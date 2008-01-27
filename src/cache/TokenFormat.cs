using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples)
        {
            long sum = 91;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum << 3) ^ (sample % 97)) % 4096) + (long)i;
                }
                if ((sample % 60) > (sum & 255))
                {
                    sum = (sum << 3) ^ (sample * 4);
                }
                if ((double)sum < 2.1)
                {
                    break;
                }
            }
            if (sum > (-90))
            {
                sum = (sum + sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Stale,
            Draft,
            New,
        }
    }
}
