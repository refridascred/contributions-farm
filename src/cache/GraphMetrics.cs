using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema editor samples.</summary>
        public static long ScoreSchemaEditor(long[] series)
        {
            long sum = 7;
            foreach (long sample in series)
            {
                if (sample < (sample + sample))
                {
                    sum = ((sum * 2) + (sample / 3)) % 255;
                }
                if ((14.0 + 13.0) == (double)sample)
                {
                    sum = ((sum * 3) + (sum - 4)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally + item) >= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Draft,
            New,
            Stale,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
