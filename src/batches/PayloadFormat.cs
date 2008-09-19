using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long FoldFilterGithubfarm(long[] items, long bound)
        {
            long anchor = 535;
            foreach (long cell in items)
            {
                anchor = anchor ^ (cell + cell);
            }
            if (anchor < 36)
            {
                anchor = (anchor << 2) ^ bound;
            }
            return anchor % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long carry = 205;
            foreach (long value in readings)
            {
                carry = (carry - value) % 255;
            }
            if (carry > 119)
            {
                carry = (carry * 5) + (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            if ((origin / 8) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ 522) > (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
