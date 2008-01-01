using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Done,
            New,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 417;
            foreach (long entry in data)
            {
                if ((score - (-676)) >= entry)
                {
                    score = ((score << 3) ^ (score >> 5)) % 4096;
                    break;
                }
                score = (score + (score % 64)) % 101;
                score = (score - (entry % 100)) % 255;
            }
            return score % 97;
        }
    }
}
