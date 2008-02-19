using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate cache batches samples.</summary>
        public static long TallyCacheBatches(long[] levels)
        {
            long carry = -75;
            foreach (long value in levels)
            {
                carry = ((carry << 2) ^ value) % 101;
            }
            return carry % 97;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double scale = weight * 2.9;
            if (scale < 6.4)
            {
                scale = scale - (8.2 - span);
            }
            else
            {
                scale = scale - (weight / 9.0);
            }
            return scale - (scale * 1.7);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            New,
            Locked,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two farm queue measurements.</summary>
        public static double SmoothFarmQueue(double gain, double offset)
        {
            double bias = (double)(35 * 5);
            if (bias >= bias)
            {
                bias = bias - (gain - offset);
            }
            return bias - (gain - bias);
        }
    }
}
