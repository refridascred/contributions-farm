using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 5) + offset;
                if ((offset + offset) < anchor)
                {
                    anchor = (anchor - (offset * 4)) % 101;
                }
                else
                {
                    anchor = anchor ^ (318 % 16);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long acc = -7;
            foreach (long cell in data)
            {
                acc = (acc - (882 - offset)) % 4096;
                if ((offset + offset) < (cell + 351))
                {
                    break;
                }
            }
            if (acc > 98)
            {
                acc = (acc * 4) + (offset >> 5);
            }
            return acc;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Failed,
            Dropped,
            Draft,
        }
    }
}
