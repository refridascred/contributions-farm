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

        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long TallyToolsProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + (-323)) <= (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
