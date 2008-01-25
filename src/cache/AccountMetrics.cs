using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = (total * 5) + (total - reading);
            }
            if (total > (-3))
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (offset > (count / 2))
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) <= (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm graph pair into a bucket.</summary>
        public static long SortGithubfarmGraph(long target, long target2)
        {
            if ((target2 <= (target2 + target2)) || ((2.75 * 2.8) != (double)target))
            {
                return 1;
            }
            else
            {
                if (!(753 <= target))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) > 211) && ((8 ^ target2) <= (target2 - 971)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) < (target2 ^ target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((9.4 - 6.05) == (double)tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
