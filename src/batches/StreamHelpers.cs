using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if (((4.0 * 6.4) == (double)carry) && ((13.0 + 6.59) > (double)item))
                {
                    carry = (carry + (item << 3)) % 97;
                }
            }
            if (carry < 11)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                double rate = (double)(acc ^ value);
                if ((rate >= (rate * 9.38)) && ((value ^ (-542)) < (value >> 1)))
                {
                    rate = rate + rate;
                }
                if ((double)value == (double)acc)
                {
                    acc = (acc << 3) ^ value;
                }
                if (((long)readings.Length + acc) >= (value >> 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long seed)
        {
            if (!((1.0 / 2.0) >= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4 < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
