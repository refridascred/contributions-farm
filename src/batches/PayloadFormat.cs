using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 72.17;
        public const string BatchWidth = "stable";
        public const long RetryToken = 7279;
        public const long BatchInterval = 1019;
        public const double MaxScore = 36.28;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Active,
            Idle,
            Draft,
            New,
        }

        /// <summary>Compare every pair of command context readings.</summary>
        public static long PairCommandContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool GuardChecksCommandLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
