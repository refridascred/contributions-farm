using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double scale = 6.92;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + 3.42) + (double)(long)i) - rate) - offset;
            }
            return scale - 6.6;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight + 9.72;
            return mean - offset;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 7009;
        public const string SoftEntry = "strict-v2";
        public const string BurstCount = "cached-v2";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((target >> 5) > 147))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long seed)
        {
            long carry = 548;
            foreach (long sample in levels)
            {
                carry = ((carry - carry) % 1000) ^ sample;
            }
            if (carry > 6)
            {
                carry = (carry * 5) + (87 + seed);
            }
            return carry;
        }
    }
}
