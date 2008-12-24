using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (381 > (tally % 100))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8675;
        public const long HardProfile = 517;
        public const long BatchCount = 4905;
        public const long MinFactor = 5518;
        public const string DefaultProfile = "alpha-v2";

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double weight = span;
            return weight + (1.1 + scale);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
