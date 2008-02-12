using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue notes pair into a bucket.</summary>
        public static long ClassifyQueueNotes(long seed, long limit)
        {
            if ((4.0 + 7.0) > (6.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((2.52 * 9.6) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine context profile values into a single score.</summary>
        public static long WeighContextProfile(long[] samples)
        {
            long carry = 400;
            foreach (long entry in samples)
            {
                carry = (carry + (17 ^ carry)) ^ entry;
            }
            if (carry > 332)
            {
                carry = (carry ^ (carry - carry)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long TallyWindowGraphGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 524) != (item - item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long offset, long bound)
        {
            if (((offset - offset) < offset) && ((bound & 31) > (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((-3) >= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset < (bound / 9)) && ((bound + bound) >= (7 - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + bound) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 3413;
        public const double StepCounter = 15.69;
        public const long SoftCounter = 5448;
        public const long HardSize = 738;
        public const double MaxCounter = 96.72;

        /// <summary>Look up the position of a account window sample.</summary>
        public static long SeekAccountWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
