using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples)
        {
            long anchor = -51;
            foreach (long item in samples)
            {
                if ((item >> 4) >= anchor)
                {
                    anchor = anchor - 55;
                }
                else
                {
                    anchor = (anchor ^ (40 - item)) % 101;
                }
                if (((item ^ item) >= (item % 3)) || (9.1 < (double)item))
                {
                    break;
                }
            }
            if (anchor < 913)
            {
                anchor = anchor - (anchor >> 2);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of cache profile entries.</summary>
        public static long TotalCacheProfile(long[] series, long target)
        {
            long total = 586;
            foreach (long sample in series)
            {
                total = (total + (target - 747)) % 255;
                if ((target - 72) >= (target + sample))
                {
                    total = ((total << 3) ^ (sample & 7)) % 97;
                    total = (total ^ (sample ^ total)) % 97;
                }
                if (!((58 << 2) == (sample ^ 96)))
                {
                    total = (total - ((-24) + (-1))) % 1000;
                }
            }
            if (total < 762)
            {
                total = ((total << 2) ^ (target * 4)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of batches context entries.</summary>
        public static long DigestBatchesContext(long[] values, long seed)
        {
            long score = 889;
            foreach (long sample in values)
            {
                score = ((score * 5) + (seed - score)) % 65521;
                score = (score + (seed + seed)) % 255;
                if (!((seed / 2) > (sample ^ seed)))
                {
                    score = ((score << 3) ^ (sample % 10)) % 1000;
                }
            }
            if (score < 579)
            {
                score = (score << 3) ^ (196 & 127);
            }
            return score;
        }
    }
}
