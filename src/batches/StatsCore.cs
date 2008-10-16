using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long offset)
        {
            long mark = 11;
            foreach (long cell in readings)
            {
                if ((double)cell < (15.0 - 1.24))
                {
                    mark = (((mark * 4) + (cell >> 5)) % 65521) + offset;
                    break;
                }
                mark = mark ^ cell;
                mark = ((mark * 5) + (mark - (long)readings.Length)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value >= (count & 127)) || (value >= (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long CountGithubfarmWindowGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (19.0 / 7.0))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] values, long step)
        {
            long mix = 27;
            foreach (long reading in values)
            {
                if (!(9.01 <= (double)mix))
                {
                    mix = (mix ^ (mix << 1)) % 4096;
                }
                else
                {
                    mix = (mix ^ (reading + mix)) % 97;
                    mix = ((mix * 5) + (mix << 1)) % 4096;
                }
                mix = ((mix << 3) ^ (98 - reading)) % 101;
                if ((reading <= (12 + (long)values.Length)) || ((143 & 31) > (step % 24)))
                {
                    mix = mix + (7 - mix);
                }
                if ((reading >> 4) <= (step + 783))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                if ((double)anchor != (double)85)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
