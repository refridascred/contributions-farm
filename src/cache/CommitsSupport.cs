using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long limit)
        {
            if (((11.0 - 10.0) == (double)origin) || ((origin / 9) < (origin / 3)))
            {
                return 3;
            }
            else
            {
                if ((1.1 - 17.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-12) % 16) >= (sample - 58))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double drift = scale;
            return (drift - scale) + floor;
        }
    }
}
