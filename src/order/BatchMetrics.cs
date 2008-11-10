using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up token tools samples.</summary>
        public static long CompareTokenToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long step)
        {
            if ((double)target < (double)545)
            {
                return 4;
            }
            else
            {
                if (((target ^ target) < ((-6) - step)) && ((target + step) > target))
                {
                    return 2;
                }
                else
                {
                    if (!(1.58 < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double rate = span - (gain + span);
            if (rate < gain)
            {
                rate = rate + (span / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (gain * 2.3)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            New,
            Synced,
            Retry,
            Ready,
        }
    }
}
