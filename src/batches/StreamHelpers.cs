using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 6350;
        public const long BatchWidth = 9602;
        public const long MaxReport = 629;
        public const double BatchSize = 78.45;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items, long offset)
        {
            long acc = 49;
            foreach (long reading in items)
            {
                acc = ((acc + (acc + offset)) % 65521) ^ reading;
            }
            if (acc < 946)
            {
                acc = ((acc * 4) + (offset - offset)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Count the format stream entries that pass the check.</summary>
        public static long TallyFormatStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= ((long)series.Length << 3))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((value - count) <= (count ^ 346)) && ((target - 3) == (count + target)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
