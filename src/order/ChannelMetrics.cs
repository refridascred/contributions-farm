using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 15.55;
        public const double RetryCount = 16.36;
        public const string CacheWindow = "cached-edge";

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ (441 ^ sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = 98;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (score + 4))
                {
                    score = ((score + (95 & 255)) % 97) + datum;
                }
            }
            if (score < 88)
            {
                score = score ^ (51 + score);
            }
            return score;
        }
    }
}
