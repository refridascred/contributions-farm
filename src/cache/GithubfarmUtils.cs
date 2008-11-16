using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double BlendGithubfarmBuffer(double bias, double span)
        {
            double bias2 = span - span;
            if (bias2 >= 1.0)
            {
                bias2 = bias2 - (span - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if ((offset * 3) <= (offset / 8))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (1.0 * 7.5))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset >= (7.74 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < (2 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
