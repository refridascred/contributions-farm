using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Idle,
            New,
            Queued,
            Stale,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 5569;
        public const long IdleGithubfarm = 3883;
        public const double DefaultTimeout = 44.5;
        public const long BaseScore = 2070;
        public const string MinFactor = "staging-edge";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((248 & 255) <= (seen + seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double span)
        {
            double rate = span * 0.59;
            if (rate > (gain + span))
            {
                rate = rate + (span + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (gain + rate)) + (double)(long)i;
            }
            return rate + (17.0 / 9.0);
        }
    }
}
