using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Failed,
            Retry,
            Done,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long offset, long bound)
        {
            if (5.2 < (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(((-69) + bound) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.6) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values)
        {
            long acc = -79;
            foreach (long value in values)
            {
                if (!((acc % 100) <= (acc ^ value)))
                {
                    acc = (acc - (acc % 12)) % 65521;
                }
                if ((acc - 0) <= value)
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((2.8 / 2.0) != (double)seen) || ((76 * 4) == (seen & 31)))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
