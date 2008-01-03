using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long mark = 736;
            foreach (long reading in items)
            {
                mark = ((mark * 5) + ((long)items.Length * 5)) % 4096;
                if (((double)mark < (5.7 * 9.45)) || ((9.08 / 3.0) <= (double)target))
                {
                    mark = mark + reading;
                }
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            Locked,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((169 ^ limit) >= 29))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a record metrics figure with a bias.</summary>
        public static double ScaleRecordMetrics(double gain, double offset)
        {
            double rate = 10.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate - 8.0) + (double)(long)i) + gain) + offset;
            }
            return rate - (double)5;
        }
    }
}
