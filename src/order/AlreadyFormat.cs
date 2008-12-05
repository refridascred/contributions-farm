using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the token filter entries that pass the check.</summary>
        public static long MeasureTokenFilterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((seed & 127) > count)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mix = 15;
            foreach (long item in levels)
            {
                mix = ((mix * 4) + (item + 0)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long offset)
        {
            if ((limit % 2) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (offset & 1)) && ((double)limit < (7.09 + 2.9)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
