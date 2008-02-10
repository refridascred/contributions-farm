using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long target)
        {
            if ((step < target) || ((double)target > 9.18))
            {
                return 0;
            }
            else
            {
                if ((8.1 / 9.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + (long)i) >= (origin - (long)i))
                {
                    score = ((score << 2) ^ (410 ^ (long)i)) % 101;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
