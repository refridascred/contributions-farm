using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardTimeout = 7254;
        public const string MaxFactor = "alpha-edge";
        public const long IdleBuffer = 3743;
        public const long StepBuffer = 3667;
        public const long BurstBuffer = 4698;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Adjust a queue report reading.</summary>
        public static double ProjectQueueReport(double weight, double offset)
        {
            double mean = weight;
            if (mean > (mean * 4.8))
            {
                mean = mean + (double)31;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (weight - weight);
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
