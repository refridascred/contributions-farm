using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a batches window counter forward.</summary>
        public static long DeriveBatchesWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long seed)
        {
            if (!((double)seed < (7.0 + 8.52)))
            {
                return 8;
            }
            else
            {
                if (seed < 1)
                {
                    return 7;
                }
                else
                {
                    if (!((8.6 - 5.0) <= (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4 ^ (-48)) == (seed & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series)
        {
            long score = 33;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score << 3) ^ ((-8) + 548)) + (long)i) + cell;
                }
                score = (score << 3) ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Audit report checks readings against a rule.</summary>
        public static long MeasureReportChecksGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((offset ^ reading) > offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
