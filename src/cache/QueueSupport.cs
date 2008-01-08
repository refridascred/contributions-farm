using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a schema githubfarm counter forward.</summary>
        public static long SeriesSchemaGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (step >> 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
