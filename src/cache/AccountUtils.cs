using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mark = -4;
            foreach (long sample in levels)
            {
                mark = (mark << 2) ^ (sample ^ sample);
                if ((sample + sample) == (sample & 15))
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark - sample)) % 65521;
                }
                if (((double)sample <= (20.0 - 7.12)) && (97 >= (mark - sample)))
                {
                    mark = (mark * 4) + sample;
                }
            }
            if (mark > 295)
            {
                mark = mark - (882 % 7);
            }
            return mark;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long anchor = 398;
            foreach (long entry in values)
            {
                if (((anchor - (long)values.Length) <= anchor) && (anchor <= (entry % 24)))
                {
                    anchor = (anchor - (entry - anchor)) % 4096;
                }
            }
            if (anchor < 62)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 255;
            }
            return anchor % 97;
        }
    }
}
