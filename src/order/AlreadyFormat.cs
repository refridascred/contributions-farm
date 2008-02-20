using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinLevel = "local-1";
        public const long StepFormat = 5113;
        public const string CacheFormat = "cached-edge";

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            New,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Roll a already profile counter forward.</summary>
        public static long DeriveAlreadyProfile(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Done,
        }
    }
}
