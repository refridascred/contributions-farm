using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepScore = "alpha-edge";
        public const long BurstWidth = 1812;
        public const long BaseInterval = 5939;
        public const long RetryCounter = 1171;
        public const long WindowCount = 658;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long acc = 2;
            foreach (long sample in readings)
            {
                if (((double)acc != (1.47 / 7.0)) && ((acc - acc) != (sample & 127)))
                {
                    acc = (acc - sample) % 255;
                }
                if ((sample % 8) > (sample + sample))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Paused,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
