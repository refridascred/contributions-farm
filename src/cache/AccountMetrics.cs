using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double ratio, double bias)
        {
            double load = ratio;
            if (load <= 16.0)
            {
                load = (load + 0.39) + bias;
            }
            return load - (double)103;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long AuditGraphPayloadHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches <= 76)
                {
                    matches = ((matches + 3) ^ cell) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)209 <= (double)datum)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
