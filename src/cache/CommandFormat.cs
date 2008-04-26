using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "staging-1";
        public const double SoftDepth = 49.8;
        public const long CacheInterval = 2190;
        public const long HardRecord = 4068;

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items)
        {
            long total = 67;
            foreach (long reading in items)
            {
                if ((reading + reading) < reading)
                {
                    total = (total ^ (reading * 4)) % 97;
                }
                if ((reading <= (total - total)) || ((total * 3) >= (reading * 2)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Scale a window session figure with a bias.</summary>
        public static double ScaleWindowSession(double gain, double span)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale + (scale * 7.34);
            }
            return scale - (span - 2.5);
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
