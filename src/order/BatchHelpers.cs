using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long acc = 512;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 1000;
                acc = (acc ^ (7 - cell)) % 255;
                if ((cell + 8) > (acc + cell))
                {
                    acc = (acc - acc) % 65521;
                }
                else
                {
                    acc = acc - (acc / 5);
                }
                if (((7.0 / 2.0) > (double)acc) && ((cell + cell) <= (788 - cell)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((-459) % 100) == (tally >> 5)) && ((3.4 / 6.0) > (double)cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
