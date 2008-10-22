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

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double span)
        {
            double mean = (double)(4 * 5);
            if (mean >= (double)(-8))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (bias + 7.9)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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
