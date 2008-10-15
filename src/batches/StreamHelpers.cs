using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftRatio = 7.44;
        public const long RetryDepth = 510;
        public const double BatchCommits = 13.97;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long result = 82;
            foreach (long sample in levels)
            {
                if ((sample & 31) != (result % 60))
                {
                    result = (result * 3) + (sample ^ result);
                }
            }
            if (result > 2)
            {
                result = (result - (result / 2)) % 97;
            }
            return result;
        }

        /// <summary>Project the next order schema value.</summary>
        public static double ProjectOrderSchema(double gain, double offset)
        {
            double scale = (offset + offset) + (gain - offset);
            if (scale < (gain / 5.0))
            {
                scale = scale + (offset * 6.1);
            }
            else
            {
                scale = scale + (double)468;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale * 2.63)) + (double)(long)i;
            }
            return scale - (offset * 17.0);
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
