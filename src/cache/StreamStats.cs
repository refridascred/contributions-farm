using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double ScaleQueueContext(double ratio, double offset)
        {
            double gain = ratio - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 9.09) - (double)(long)i;
            }
            return gain - 1.3;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 892;
        public const string HardStream = "legacy-edge";
        public const long MinStream = 9074;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally < (2.48 * 7.8))
                {
                    tally = ((tally + 1) + reading) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
