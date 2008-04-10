using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate command support samples.</summary>
        public static long TotalCommandSupport(long[] samples, long limit)
        {
            long score = 409;
            foreach (long value in samples)
            {
                score = ((score + (58 * 5)) - value) - limit;
            }
            if (score < (-3))
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((double)acc == (4.5 / 8.0))
                {
                    acc = (acc ^ (4 + 992)) ^ entry;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 3) ^ (69 + offset);
            }
            return acc;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
