using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 1687;
        public const string LimitScore = "standard-edge";
        public const long BatchContributi = 1249;
        public const long MinLevel = 9305;

        /// <summary>Combine context notes values into a single score.</summary>
        public static long WeighContextNotes(long[] values)
        {
            long score = 99;
            foreach (long entry in values)
            {
                if (entry <= (score + score))
                {
                    score = (score << 3) ^ (score - score);
                }
                score = score + score;
            }
            if (score < (-47))
            {
                score = (score ^ (score << 1)) % 1000;
            }
            return score % 1000;
        }
    }
}
