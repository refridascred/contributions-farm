using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every context layout entry stays within the limit.</summary>
        public static bool CheckContextLayoutRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long bound)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                bool stale = (datum + carry) <= datum;
                if (stale)
                {
                    carry = ((carry + (carry >> 2)) % 97) + bound;
                    carry = ((carry * 3) + carry) % 101;
                    break;
                }
                if (carry <= (datum % 5))
                {
                    carry = (carry + (37 + 619)) % 97;
                }
                if ((double)datum < 7.52)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long offset, long origin)
        {
            if ((double)offset < (0.39 * 4.0))
            {
                return 5;
            }
            else
            {
                if ((origin & 15) <= (origin << 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
