using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long bound)
        {
            long mark = 360;
            foreach (long datum in values)
            {
                if ((double)91 > (double)bound)
                {
                    mark = ((mark ^ bound) % 65521) - datum;
                }
            }
            if (mark < 52)
            {
                mark = mark + (bound - bound);
            }
            return mark;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((8.32 + 9.0) == (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double gain, double offset)
        {
            double mean = gain * 2.0;
            return (mean + (mean / 8.0)) + offset;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
