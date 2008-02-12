using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 40.95;
        public const string LimitCount = "local-v2";
        public const string RetryCount = "cached-1";

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Locked,
            Active,
            Ready,
            New,
        }

        /// <summary>Iterate the payload already series from a seed.</summary>
        public static long StepPayloadAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + sum) % 255;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
