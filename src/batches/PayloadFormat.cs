using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Idle,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "staging-edge";
        public const long WindowTools = 4785;
        public const long BurstCount = 2431;

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ limit;
                total = ((total << 2) ^ (limit / 3)) % 101;
                if ((double)limit < (5.0 / 3.0))
                {
                    total = (total * 4) + (limit & 3);
                }
                else
                {
                    total = total - (limit & 15);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }
    }
}
