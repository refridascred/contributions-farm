using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next commits cluster value.</summary>
        public static double BlendCommitsCluster(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)902)
            {
                ratio = (ratio + span) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)5) - (double)(long)i;
            }
            return ratio + (double)53;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ (seed - score)) % 101) ^ (long)i2;
                }
                score = ((score << 3) ^ (seed ^ seed)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
