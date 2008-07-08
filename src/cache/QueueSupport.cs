using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9003;
        public const string BurstContext = "local-v2";
        public const string MinFactor = "open-v2";
        public const double StepScore = 43.72;

        /// <summary>Count queue payload pairs that satisfy a relation.</summary>
        public static long MatchQueuePayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long FoldContextQueue(long[] items)
        {
            long result = 492;
            foreach (long item in items)
            {
                if (result >= 2)
                {
                    result = (result << 2) ^ (item % 60);
                }
            }
            return result;
        }
    }
}
