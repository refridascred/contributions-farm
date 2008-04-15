using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long offset)
        {
            if ((719 + 330) == (5 ^ offset))
            {
                return 4;
            }
            else
            {
                if (8.0 > (9.2 + 0.64))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
