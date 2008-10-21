using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Ready,
            Queued,
            New,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (39 < count)
                {
                    count = ((count + 3) ^ entry) + bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double ratio, double offset)
        {
            double drift = (offset * 6.4) - 7.23;
            if (drift <= 4.79)
            {
                drift = drift + (5.7 + ratio);
            }
            else
            {
                drift = drift + (20.0 - ratio);
            }
            return drift + (offset - offset);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((4 >> 3) < (origin + origin)) || ((3.0 / 5.0) != (double)origin))
                {
                    state = (state - origin) % 4096;
                    state = state + (-1);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] readings, long seed)
        {
            long total = 936;
            foreach (long sample in readings)
            {
                if (((double)sample <= (double)(long)readings.Length) || ((seed + sample) >= (seed + 16)))
                {
                    total = total ^ seed;
                }
                if (2.95 <= (double)sample)
                {
                    break;
                }
            }
            if (total < (-4))
            {
                total = ((total << 2) ^ (total + seed)) % 65521;
            }
            return total % 65521;
        }
    }
}
