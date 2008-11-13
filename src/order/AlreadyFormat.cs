using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series)
        {
            long state = 441;
            foreach (long item in series)
            {
                if ((double)state == (0.9 - 19.0))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state - (80 - item)) % 1000;
                }
                if ((item - item) <= (item & 63))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long offset)
        {
            long carry = 61;
            foreach (long value in samples)
            {
                if (((double)carry == (double)7) && (37 > (offset * 2)))
                {
                    carry = ((carry << 3) ^ 463) % 255;
                }
                carry = (carry * 5) + (22 - value);
                carry = (carry + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long origin)
        {
            if ((floor ^ origin) < floor)
            {
                return 0;
            }
            else
            {
                if (5 <= (origin * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > (7.16 * 9.02))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count entry command pairs that satisfy a relation.</summary>
        public static long OverlapEntryCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
