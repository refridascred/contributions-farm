using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long MeasureGithubfarmContextOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((49 * 3) <= limit)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Digest a series of format contributi entries.</summary>
        public static long WeighFormatContributi(long[] series)
        {
            long mark = 62;
            foreach (long reading in series)
            {
                if (((9.99 - 0.5) <= (double)reading) && (reading >= (reading - mark)))
                {
                    mark = ((mark * 2) + (reading + 909)) % 4096;
                }
                if (!(((long)series.Length & 7) > reading))
                {
                    mark = (mark * 2) + reading;
                }
                mark = (mark << 3) ^ (reading - (long)series.Length);
            }
            return mark;
        }

        /// <summary>Accumulate context metrics samples.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long total = 10;
            foreach (long entry in levels)
            {
                if (entry > (78 + total))
                {
                    total = total ^ ((long)levels.Length / 5);
                }
            }
            if (total < 8)
            {
                total = (total + (total << 3)) % 255;
            }
            return total;
        }
    }
}
