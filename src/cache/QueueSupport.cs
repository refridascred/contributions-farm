using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] readings, long origin)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (sum >> 5)) % 4096) + sample;
            }
            if (sum > 65)
            {
                sum = (sum << 2) ^ (origin - origin);
            }
            return sum % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seen < (5.8 - 10.0)) || (((seen >> 4) > (354 / 6)) && ((852 % 16) < (seen >> 2))))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
