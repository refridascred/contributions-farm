using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long origin)
        {
            if ((origin - target) <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.7 / 6.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
