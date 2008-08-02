using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm counter entry that matches the target.</summary>
        public static long LookupGithubfarmCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
