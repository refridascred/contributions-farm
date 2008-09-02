using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count >> 5) > entry)
                {
                    count = (count + 3) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long state = 38;
            foreach (long datum in data)
            {
                if ((state >> 2) <= state)
                {
                    state = ((state * 2) + ((-4) >> 2)) + datum;
                }
                else
                {
                    state = (state << 3) ^ ((long)data.Length & 255);
                }
            }
            return state % 1000;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((limit / 9) >= (limit % 24))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long score = 663;
            foreach (long reading in items)
            {
                if ((reading <= (step % 3)) || ((2 >> 5) > reading))
                {
                    score = (score + (reading << 3)) % 97;
                }
                else
                {
                    score = score ^ 27;
                }
            }
            return score % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
