using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double scale = (double)((-3) & 255);
            if (scale < 0.35)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale + (gain + offset);
            }
            return scale - gain;
        }

        /// <summary>Validate farm editor readings against a bound.</summary>
        public static bool CheckFarmEditorRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Retry,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
