using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample >> 2) < (92 >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest-1";
        public const long WindowQueue = 8246;
        public const long BurstScore = 9823;
        public const long BurstQueue = 1163;

        /// <summary>Check that every counter session entry stays within the limit.</summary>
        public static bool ValidateCounterSessionRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
