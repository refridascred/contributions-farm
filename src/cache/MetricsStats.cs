using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Roll a record counter counter forward.</summary>
        public static long SeriesRecordCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + step) <= state)
                {
                    state = ((state << 3) ^ (step + state)) % 97;
                    state = (state << 3) ^ state;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count / 9) >= (entry & 7))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > ((long)samples.Length / 9))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double gain = floor;
            if (gain > (rate + floor))
            {
                gain = gain + floor;
            }
            return gain - floor;
        }
    }
}
