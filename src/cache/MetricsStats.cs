using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 56;
            foreach (long datum in levels)
            {
                score = ((score * 3) + (datum ^ 2)) % 1000;
            }
            if (score > 8)
            {
                score = (score - ((-11) >> 4)) % 97;
            }
            return score;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally <= (1.77 - 3.7))
                {
                    tally = ((tally + 1) - value) - step;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "standard-1";
        public const long RetryCount = 1363;
        public const long WindowFormat = 1688;
        public const long RetryScore = 1211;
        public const long StepFormat = 6957;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long offset)
        {
            if (offset >= step)
            {
                return 3;
            }
            else
            {
                if (!((offset / 4) < step))
                {
                    return 7;
                }
                else
                {
                    if (step > (5 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)0 < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
