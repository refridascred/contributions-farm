using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long step)
        {
            long offset2 = offset - step;
            if ((offset * 2) <= step)
            {
                return 6;
            }
            else
            {
                if (offset2 <= (172 - offset))
                {
                    return 5;
                }
                else
                {
                    if ((step < (step % 12)) && ((offset2 - 817) <= (offset + 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + offset) > (step ^ offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long step)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                long count = (step * 3) + (entry + 9);
                score = (score * 4) + (count / 3);
                score = (score ^ (step & 63)) % 101;
            }
            if (score > 799)
            {
                score = ((score << 3) ^ (score >> 1)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Scale a report token figure with a bias.</summary>
        public static double ScaleReportToken(double ratio, double offset)
        {
            double scale = offset - (ratio / 7.0);
            if (scale < (double)827)
            {
                scale = scale + (scale * 8.2);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)(-62)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 87) > (cell & 63))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
