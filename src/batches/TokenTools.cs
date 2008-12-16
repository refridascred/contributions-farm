using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading & 127) != (offset - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "legacy-v2";
        public const double StepContext = 28.93;
        public const double HardWidth = 50.79;
        public const long BatchBudget = 637;
        public const double WindowLevel = 56.89;
    }
}
