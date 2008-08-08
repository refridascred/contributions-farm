using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((score * 5) == (long)i)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Queued,
            Draft,
            Retry,
        }
    }
}
