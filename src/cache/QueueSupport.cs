using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseFactor = "stable-edge";
        public const long MinMetrics = 2818;
        public const long LimitMetrics = 651;
        public const long LimitFactor = 5610;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = (double)(37 << 2);
            if (load <= (bias + 14.0))
            {
                load = (load + (load / 5.0)) + scale;
            }
            else
            {
                load = load - (double)275;
            }
            return load + (double)0;
        }
    }
}
