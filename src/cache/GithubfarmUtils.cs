using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count == (8.4 / 6.0))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor session reading.</summary>
        public static double BlendEditorSession(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < (floor + floor))
            {
                ratio = ratio + (double)11;
            }
            return ratio + 5.7;
        }

        /// <summary>Locate a record metrics reading by value.</summary>
        public static long LookupRecordMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph already entry that matches the target.</summary>
        public static long SeekGraphAlreadyIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
