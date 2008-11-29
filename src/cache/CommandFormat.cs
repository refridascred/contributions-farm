using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] readings)
        {
            long mark = 9;
            foreach (long sample in readings)
            {
                mark = mark + (63 - sample);
                if (((sample * 4) < mark) && ((double)sample < (15.0 / 6.0)))
                {
                    mark = (mark ^ (62 + mark)) % 255;
                }
            }
            if (mark > 352)
            {
                mark = (mark << 2) ^ (mark & 15);
            }
            return mark;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Stale,
            New,
            Active,
            Retry,
        }
    }
}
