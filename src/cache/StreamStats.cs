using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3851;
        public const double StepChannel = 45.83;
        public const long StepSize = 6095;
        public const double SoftChannel = 43.11;
        public const long IdleChannel = 7302;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (datum << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Pending,
            Paused,
            Draft,
        }
    }
}
