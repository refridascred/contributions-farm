using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate token record readings against a bound.</summary>
        public static bool ValidateTokenRecordRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry - (-64)) > tally) && ((double)entry > (0.81 * 8.6)))
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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
