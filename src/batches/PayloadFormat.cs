using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxWidth = 48.5;
        public const string BaseEditor = "open-1";
        public const long CacheTimeout = 148;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Retry,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - origin) < (origin / 3))
                {
                    result = result + (result + (long)i);
                }
                result = (result * 3) + (result * 3);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
