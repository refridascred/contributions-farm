using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = score ^ (66 + score);
                score = score - (score - limit);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
