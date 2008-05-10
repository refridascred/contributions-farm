using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double drift = (span * 10.0) - (span + span);
            if (drift < drift)
            {
                drift = (drift + span) + gain;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift - (double)688;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] items, long target)
        {
            long score = 925;
            foreach (long sample in items)
            {
                if (!!((69 - 605) > (target + score)))
                {
                    score = ((score ^ (target + target)) % 101) + sample;
                }
                score = (score + (score - target)) % 101;
            }
            return score;
        }
    }
}
