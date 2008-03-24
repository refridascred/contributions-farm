using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Locked,
            Idle,
            Active,
            Ready,
            Done,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long total = 5;
            foreach (long reading in series)
            {
                total = total ^ (reading % 12);
            }
            return total;
        }
    }
}
