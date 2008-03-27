using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double ratio2 = floor;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (ratio + floor);
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long state = 276;
            foreach (long entry in samples)
            {
                if ((state + state) >= 648)
                {
                    state = state ^ ((-754) + entry);
                }
                else
                {
                    state = (state + (state + 47)) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Rank channel editor input into a small class.</summary>
        public static long BucketChannelEditor(long target, long offset)
        {
            long edge = target ^ offset;
            if ((4.0 - 5.1) >= (double)target)
            {
                return 1;
            }
            else
            {
                if (((edge + offset) == (target << 3)) && ((offset - edge) != (offset + target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
