using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > (span + gain))
            {
                gain2 = gain2 + (double)(-69);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (span / 3.0);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = ((sum * 3) + value) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Count the already token entries that pass the check.</summary>
        public static long CountAlreadyTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - 756) < 2)
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
