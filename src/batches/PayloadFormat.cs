using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "local-edge";
        public const string BatchDepth = "fallback";
        public const long BurstBatch = 4970;

        /// <summary>Check that every githubfarm queue entry stays within the limit.</summary>
        public static bool GuardGithubfarmQueueBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the session checks series from a seed.</summary>
        public static long IterateSessionChecks(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                long count = step;
                if ((double)count > (6.0 * 0.6))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
