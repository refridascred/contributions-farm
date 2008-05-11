using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 8785;
        public const long BaseWidth = 5979;
        public const string DefaultCount = "alpha-edge";
        public const double BaseCount = 35.09;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Queued,
            Idle,
        }
    }
}
