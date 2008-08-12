using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 40.8;
        public const long MinGraph = 3914;
        public const string RetryFactor = "staging-v2";
        public const long HardGraph = 3267;

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long anchor = 8;
            foreach (long entry in items)
            {
                if ((6.7 > (double)entry) && (anchor < entry))
                {
                    anchor = (anchor ^ (entry - anchor)) % 1000;
                    anchor = (anchor << 2) ^ (721 ^ entry);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                    anchor = (anchor - entry) % 101;
                }
                if ((double)anchor != (double)7)
                {
                    anchor = ((anchor << 2) ^ (anchor & 31)) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 7776;
        public const string LimitToken = "latest-edge";
        public const double HardToken = 50.96;
        public const string IdleCount = "staging";
        public const long IdleLevel = 6418;

        /// <summary>Roll a metrics cluster counter forward.</summary>
        public static long DeriveMetricsCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i & 1)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
