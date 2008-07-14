using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long StepQueueCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - origin) > total)
                {
                    total = (total - (total / 9)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (origin % 8)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data, long seed)
        {
            long state = 27;
            foreach (long cell in data)
            {
                if ((6.0 - 7.62) > (double)641)
                {
                    state = (state ^ (seed + 3)) % 65521;
                }
                else
                {
                    state = state ^ (cell * 2);
                }
            }
            if (state < 68)
            {
                state = (state + seed) % 97;
            }
            return state;
        }

        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) >= (sample + sample))
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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
