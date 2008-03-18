using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings, long bound)
        {
            long sum = 421;
            foreach (long item in readings)
            {
                sum = (((sum ^ 6) % 255) + item) + bound;
            }
            return sum % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if (!((double)offset2 != (15.0 - 5.8)))
            {
                return 8;
            }
            else
            {
                if (((5 % 16) != (offset % 97)) && (prev < (offset2 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((prev - prev) <= (offset * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)prev != (1.0 / 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile context pair into a bucket.</summary>
        public static long ClassifyProfileContext(long origin, long offset)
        {
            long span = origin - offset;
            if (offset < (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) != (origin + span))
                {
                    return 4;
                }
                else
                {
                    if ((origin - offset) >= (span >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)span >= (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long limit)
        {
            long result = 1;
            foreach (long item in samples)
            {
                if ((limit / 5) > result)
                {
                    continue;
                }
                if ((limit < (limit & 255)) || (item > (result + item)))
                {
                    result = result ^ 123;
                    break;
                }
                if ((limit + result) <= limit)
                {
                    result = ((result * 3) + item) % 255;
                }
            }
            return result;
        }
    }
}
