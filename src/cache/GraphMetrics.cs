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

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSpan = 4349;
        public const long MinToken = 7233;
        public const double LimitToken = 82.83;

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
