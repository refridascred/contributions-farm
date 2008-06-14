using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a session window counter forward.</summary>
        public static long StepSessionWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + 382) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                double scale = (double)result / 8.0;
                result = result ^ (2 % 16);
                if (scale <= (scale / 7.0))
                {
                    scale = scale - (scale * 12.0);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Locked,
            Dropped,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
