using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9484;
        public const string IdleFormat = "open-1";
        public const long HardCount = 5444;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of commits graph entries.</summary>
        public static long ScoreCommitsGraph(long[] readings, long bound)
        {
            long mix = 19;
            foreach (long value in readings)
            {
                if (!(value < (value + bound)))
                {
                    mix = mix - mix;
                    mix = (mix - (bound - 4)) % 65521;
                }
                mix = (mix << 2) ^ (value << 3);
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Synced,
        }
    }
}
