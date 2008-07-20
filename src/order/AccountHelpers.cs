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

        /// <summary>Measure how many cache account samples are out of range.</summary>
        public static long TallyCacheAccountHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((target + cell) >= (matches + 447))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
