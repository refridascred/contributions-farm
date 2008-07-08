using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long bound)
        {
            long span = target ^ bound;
            if ((74 + bound) != (6 & 127))
            {
                return 2;
            }
            else
            {
                if ((double)span >= (8.54 * 5.75))
                {
                    return 1;
                }
                else
                {
                    if (((target + span) > bound) || ((target + bound) <= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target - span) <= (target << 3)) && ((8.08 - 7.9) >= (double)span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if (!((sum & 15) == (value & 3)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                else
                {
                    sum = (sum * 2) + (limit << 2);
                }
                if ((limit & 31) == ((long)values.Length + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((offset ^ reading) > offset))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Queued,
            Ready,
            New,
        }
    }
}
