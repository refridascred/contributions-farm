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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long offset)
        {
            long prev = bound + offset;
            if (((8.2 - 5.7) > (double)bound) || ((double)prev < (4.25 + 8.27)))
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((99 & 1) >= (bound >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev + bound) >= prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
