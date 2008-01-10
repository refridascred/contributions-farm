using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long mark = 62;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark / 8)) % 97) + datum) + origin;
            }
            if (mark < 190)
            {
                mark = (mark ^ (mark * 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double bias = scale;
            return (bias + 0.5) + offset;
        }

        /// <summary>Accumulate cluster filter samples.</summary>
        public static long TotalClusterFilter(long[] values, long bound)
        {
            long anchor = 801;
            foreach (long entry in values)
            {
                if (!(entry > (bound + 22)))
                {
                    anchor = anchor ^ (bound + anchor);
                }
                else
                {
                    anchor = (anchor - (424 + 483)) % 4096;
                }
            }
            if (anchor > (-283))
            {
                anchor = anchor ^ 881;
            }
            return anchor % 97;
        }

        /// <summary>Blend two session filter measurements.</summary>
        public static double ProjectSessionFilter(double gain, double span)
        {
            double gain2 = (double)(6 - 904);
            if (gain2 < gain2)
            {
                gain2 = (gain2 - (gain2 - 3.91)) - gain;
            }
            else
            {
                gain2 = gain2 - (gain2 + gain2);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (span - span)) + (double)(long)i;
            }
            return gain2 + 2.0;
        }
    }
}
