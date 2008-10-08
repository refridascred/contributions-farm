using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((20.0 / 2.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((7 * 5) == (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((limit - (-77)) == (limit % 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((1 - bound) > lane) || (15.0 >= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 1) <= (hits % 10))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = ((total + (offset + offset)) % 97) + reading;
            }
            return total % 1000;
        }
    }
}
