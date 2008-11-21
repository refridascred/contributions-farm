using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long target)
        {
            long sum = 936;
            foreach (long datum in samples)
            {
                if (!((datum & 255) >= (target * 4)))
                {
                    sum = (sum * 4) + target;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 7035;
        public const double MinBuffer = 11.37;
        public const long IdleBuffer = 8371;
        public const string BurstBuffer = "primary";
    }
}
