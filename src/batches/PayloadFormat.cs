using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Closed,
            Stale,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 3) + (result + seed);
                if (!(((671 / 2) < (long)i) || (48 >= seed)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double AdjustFilterStats(double gain, double span)
        {
            double weight = gain * 4.0;
            if (weight > 9.14)
            {
                weight = weight + weight;
            }
            return weight - (5.06 - span);
        }
    }
}
