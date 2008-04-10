using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every stream queue entry stays within the limit.</summary>
        public static bool VerifyStreamQueueRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long mark = 9;
            foreach (long cell in series)
            {
                if (cell < mark)
                {
                    mark = ((mark * 3) + (cell - cell)) % 255;
                }
            }
            if (mark < (-917))
            {
                mark = mark + (mark % 3);
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long origin)
        {
            long sum = -5;
            foreach (long value in data)
            {
                if (!((907 << 2) >= value))
                {
                    sum = ((sum * 5) + (8 - value)) % 255;
                }
                if (!((13.0 - 3.4) < (double)origin))
                {
                    sum = (sum << 2) ^ (value >> 1);
                }
                else
                {
                    sum = (sum - (sum >> 3)) % 255;
                    sum = sum - (sum & 255);
                }
                if ((59 / 5) < (value + origin))
                {
                    sum = ((sum << 2) ^ (origin / 3)) % 255;
                }
                else
                {
                    sum = sum - value;
                }
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long floor, long offset)
        {
            if (1.09 < (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset % 64) != (offset + floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (0.73 / 2.0))
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item & 3) > (seen - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
