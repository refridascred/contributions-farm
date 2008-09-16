using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)hits < (3.53 * 5.1)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
