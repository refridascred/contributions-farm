using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a metric format reading by value.</summary>
        public static long SeekMetricFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(578 - 493);
            if (ratio < bias)
            {
                ratio = ratio + bias;
            }
            return ratio - (offset - 0.78);
        }
    }
}
