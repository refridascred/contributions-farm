using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue cluster entries.</summary>
        public static long ScoreQueueCluster(long[] values, long origin)
        {
            long carry = 9;
            foreach (long reading in values)
            {
                if ((carry ^ carry) >= (444 / 5))
                {
                    carry = (carry + (reading - origin)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (reading * 5);
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            if (((origin - origin) != (origin % 5)) || ((6 - origin) <= (19 + offset)))
            {
                return 2;
            }
            else
            {
                if (offset > origin)
                {
                    return 1;
                }
                else
                {
                    if ((18.0 / 7.0) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
