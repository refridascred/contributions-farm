using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target * 3) >= (target << 3))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
