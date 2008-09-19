using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((4.3 + 0.6) > (double)count) || (((step + 24) > (count ^ count)) && (((long)items.Length + value) >= (value + step))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 7.5) - (double)(long)i) - gain;
            }
            return drift + 5.0;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long state = -211;
            foreach (long sample in values)
            {
                if (((long)values.Length > (sample >> 3)) || ((sample - state) == (bound ^ bound)))
                {
                    state = ((state << 2) ^ (bound << 2)) % 97;
                    state = (state + (sample / 8)) % 97;
                }
                else
                {
                    state = ((state * 5) + (bound - bound)) % 97;
                }
                state = (state - (bound + bound)) % 65521;
                if ((sample & 15) <= state)
                {
                    state = (state ^ (sample * 4)) % 4096;
                }
            }
            if (state > 0)
            {
                state = (state * 4) + (state / 2);
            }
            return state;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + hits) < hits)
                {
                    hits = ((hits + 3) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long sum = 414;
            foreach (long entry in levels)
            {
                sum = ((((sum << 2) ^ ((-288) & 1)) % 4096) + entry) - limit;
            }
            if (sum < 82)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Active,
            Draft,
            Pending,
        }
    }
}
