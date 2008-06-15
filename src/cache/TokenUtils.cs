using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double drift = 5.0 + (ratio * 7.0);
            if (drift < 5.7)
            {
                drift = (drift + (double)41) - span;
            }
            else
            {
                drift = drift - (drift - drift);
            }
            return drift - drift;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ ((long)i + bound);
                score = score + (568 - 94);
                score = score ^ bound;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Draft,
            Synced,
        }
    }
}
