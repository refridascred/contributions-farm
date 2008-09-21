using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Pending,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading >= bound) || (((long)samples.Length % 2) < (reading % 100))) && ((seen << 3) < (seen + reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((result * 2) >= result)
                {
                    result = result ^ (origin + result);
                    result = (result - (result / 5)) % 255;
                }
                else
                {
                    result = (result + ((long)i + origin)) % 1000;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (1 > (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
