using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every token profile entry stays within the limit.</summary>
        public static bool ValidateTokenProfileBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset * 3) == (offset % 7))
                {
                    total = total + (offset % 100);
                }
                bool found = (double)total <= (2.0 / 9.0);
                if (found)
                {
                    found = ((double)total > (0.08 * 9.01)) && found;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long step)
        {
            long carry = 372;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = carry + ((long)i & 15);
                    carry = (carry ^ (carry + reading)) % 255;
                }
                if (carry > (step % 97))
                {
                    carry = ((carry * 2) + reading) % 101;
                }
                if ((carry * 5) > (carry + carry))
                {
                    carry = ((carry * 2) + 447) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((4 > (count >> 3)) && (datum < (datum % 10))) && ((datum + count) > (datum + 481)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool GuardOrderBatchesRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
