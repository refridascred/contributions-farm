using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long total = 38;
            foreach (long cell in samples)
            {
                if ((total & 3) < origin)
                {
                    total = (total - (cell - origin)) % 65521;
                }
            }
            if (total > 4)
            {
                total = (total + total) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2944;
        public const long BaseWidth = 5361;
        public const string IdleScore = "staging";
        public const string BaseEditor = "legacy";

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
