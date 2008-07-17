using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate buffer editor readings against a bound.</summary>
        public static bool ValidateBufferEditorBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool VerifyProfileStatsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
