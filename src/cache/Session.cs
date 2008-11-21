using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((origin * 3) == (entry - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm stats reading by value.</summary>
        public static long SeekFarmStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long SeriesToolsChannel(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if (((226 - step) >= (step - step)) || ((2.0 + 3.0) <= (double)mark))
                {
                    mark = (mark - (247 >> 3)) % 255;
                }
                else
                {
                    mark = mark ^ (9 - mark);
                }
                if (!((step <= (mark ^ step)) || ((2.0 + 5.0) <= (double)(long)i)))
                {
                    mark = ((mark << 2) ^ (step + mark)) % 101;
                    mark = (mark + (step ^ (long)i)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                if ((double)result <= 9.5)
                {
                    result = (((result * 5) + (result * 5)) % 4096) ^ cell;
                }
            }
            return result;
        }
    }
}
