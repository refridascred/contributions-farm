using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context stats readings against a rule.</summary>
        public static long CountContextStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches <= (datum & 127))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long limit)
        {
            if ((limit + limit) >= (-5))
            {
                return 5;
            }
            else
            {
                if (((limit + 42) > (origin % 64)) && ((double)limit > 8.5))
                {
                    return 6;
                }
                else
                {
                    if (8.4 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit >= (175 << 3)) || ((origin & 31) <= origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally <= (1.0 - 2.4))
                {
                    tally = ((tally + 3) ^ reading) + origin;
                }
            }
            return tally;
        }
    }
}
