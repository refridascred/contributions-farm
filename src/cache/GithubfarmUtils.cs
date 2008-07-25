using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long target)
        {
            long anchor = 77;
            foreach (long item in samples)
            {
                if ((item >> 5) <= (item + 46))
                {
                    anchor = ((anchor ^ item) % 65521) - target;
                }
                else
                {
                    anchor = (anchor + (anchor / 7)) % 255;
                }
            }
            if (anchor > (-9))
            {
                anchor = anchor + (anchor + 97);
            }
            return anchor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long sum = 9;
            foreach (long item in values)
            {
                sum = ((sum * 5) + (item & 15)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
