using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
