using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double weight = (double)690;
            if (weight > 19.0)
            {
                weight = weight + (bias * 18.0);
            }
            else
            {
                weight = weight + (span / 4.0);
            }
            return weight + (span * 8.18);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((((value - tally) < (value << 1)) && ((tally * 4) > tally)) && ((734 % 16) < (limit % 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session counter samples are out of range.</summary>
        public static long AuditSessionCounterGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((step * 2) > (matches / 7))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long offset2)
        {
            long step = offset + offset2;
            if (61 <= (step - offset))
            {
                return 7;
            }
            else
            {
                if ((offset2 << 1) < step)
                {
                    return 6;
                }
                else
                {
                    if ((((-40) & 7) > offset) && (offset < (step - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset2 + step) == (2 + step)) || ((offset2 ^ offset) <= (9 + 743)))
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
    }
}
