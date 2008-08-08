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

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double drift = ratio;
            if (drift < (9.0 * 1.2))
            {
                drift = drift + offset;
            }
            return drift - 4.25;
        }
    }
}
