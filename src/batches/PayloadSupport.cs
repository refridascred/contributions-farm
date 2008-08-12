using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepScore = "primary-v2";
        public const long IdleScore = 1655;
        public const long BaseLevel = 9268;

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long target)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if ((1 - value) >= (-84))
                {
                    break;
                }
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 3) ^ (5 ^ 7)) % 1000) + (long)i;
                }
                score = score + (value - 91);
            }
            if (score > 76)
            {
                score = score ^ target;
            }
            return score;
        }
    }
}
