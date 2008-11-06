using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally / 6) != (bound + item)))
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

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long origin)
        {
            long result = 133;
            foreach (long datum in items)
            {
                if (((datum & 31) < (758 >> 2)) && ((double)origin != (5.0 * 12.0)))
                {
                    result = ((result * 3) + (origin + origin)) % 97;
                }
                result = result - (datum + 74);
            }
            return result;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "standard-edge";
        public const double DefaultBatch = 64.87;
        public const long MinBatch = 1350;
        public const long BaseBatch = 3044;

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double ratio2 = 5.34;
            if (ratio2 >= 1.54)
            {
                ratio2 = (ratio2 - (span * 9.9)) - ratio;
            }
            return ratio2 - 1.58;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long step, long floor)
        {
            long offset = step + floor;
            if (4 <= (offset + step))
            {
                return 2;
            }
            else
            {
                if ((step << 2) < (floor + 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (2.2 * 3.41))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor + offset) >= offset)
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
        }
    }
}
