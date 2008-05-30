using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long total = 1;
            foreach (long cell in data)
            {
                total = ((total ^ (total * 4)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double weight = span;
            return weight - (rate / 7.0);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long offset, long bound)
        {
            if ((offset - 896) >= offset)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 90) != (offset % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound <= (8.0 * 5.65))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
