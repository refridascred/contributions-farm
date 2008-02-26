using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items)
        {
            long mark = 8;
            foreach (long entry in items)
            {
                if ((mark * 3) > entry)
                {
                    mark = (mark ^ ((long)items.Length % 10)) % 1000;
                }
                mark = mark - (entry - 792);
                if (((long)items.Length * 4) < (mark & 1))
                {
                    break;
                }
            }
            if (mark > 77)
            {
                mark = (mark + (mark * 2)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Active,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double weight = floor;
            if (weight >= 0.64)
            {
                weight = weight + (scale - scale);
            }
            else
            {
                weight = weight - (double)0;
            }
            return weight - (floor + floor);
        }
    }
}
