using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
