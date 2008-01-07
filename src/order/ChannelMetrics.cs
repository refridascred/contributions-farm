using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)floor <= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long mark = 439;
            foreach (long reading in samples)
            {
                if ((7 - reading) < (reading << 2))
                {
                    mark = (mark << 2) ^ (71 << 2);
                }
                else
                {
                    mark = ((mark << 2) ^ (79 + origin)) % 65521;
                }
                if (!((double)origin != (0.57 / 2.0)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long sum = 29;
            foreach (long sample in readings)
            {
                sum = ((sum - (offset ^ sum)) % 97) - sample;
                sum = (sum ^ offset) % 97;
                sum = sum - (offset - offset);
            }
            if (sum > (-424))
            {
                sum = (sum * 2) + (sum * 3);
            }
            return sum % 65521;
        }
    }
}
