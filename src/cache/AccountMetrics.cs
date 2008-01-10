using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples, long offset)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                if (5.2 < 9.7)
                {
                    mix = (((mix * 2) + offset) % 1000) + reading;
                }
                if ((mix >> 5) > (mix - offset))
                {
                    break;
                }
            }
            if (mix > 156)
            {
                mix = ((mix * 2) + (offset + 24)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long seed)
        {
            long slot = limit + seed;
            if ((seed - slot) < limit)
            {
                return 2;
            }
            else
            {
                if (1.17 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((6.9 * 3.0) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first queue route entry that matches the target.</summary>
        public static long SeekQueueRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
