using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Stale,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples, long step)
        {
            long mix = -91;
            foreach (long item in samples)
            {
                mix = ((mix - 9) + item) + step;
            }
            return mix % 4096;
        }
    }
}
