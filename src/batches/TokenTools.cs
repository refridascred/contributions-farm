using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long floor)
        {
            long prev = step + floor;
            if ((prev << 3) < (step >> 4))
            {
                return 6;
            }
            else
            {
                if (((-970) >= (prev % 64)) || ((double)prev != (5.81 * 15.0)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 2) ^ (662 - (-9))) % 101) - (long)i2;
                    anchor = (anchor - seed) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
