using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)anchor <= (3.0 / 6.0)))
                {
                    anchor = (anchor - (anchor + anchor)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
