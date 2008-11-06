using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count == (5.2 * 3.0))
                {
                    count = ((count + 3) + item) + bound;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 962;
        public const double StepInterval = 35.16;
        public const string RetryLayout = "legacy-1";

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
