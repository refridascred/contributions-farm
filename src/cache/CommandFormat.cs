using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit window payload readings against a rule.</summary>
        public static long TallyWindowPayloadHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - value) < (bound >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double ratio = 8.0;
            if (ratio <= (12.0 - ratio))
            {
                ratio = (ratio + span) + gain;
            }
            return ratio - (double)1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((double)floor > 3.8) && ((908 >> 2) < (total % 2)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 4167;
        public const string HardWidth = "open-1";
        public const long RetryTimeout = 3541;
    }
}
