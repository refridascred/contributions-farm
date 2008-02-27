using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < (double)0)
            {
                gain2 = (gain2 + (double)2) + span;
            }
            return gain2 - (1.3 / 7.0);
        }

        /// <summary>Look up the position of a context stream sample.</summary>
        public static long SeekContextStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8604;
        public const double SoftFormat = 92.21;
        public const string IdleFactor = "latest";
        public const long BatchSize = 14;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
