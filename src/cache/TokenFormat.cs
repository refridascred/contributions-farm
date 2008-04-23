using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter support samples.</summary>
        public static long TallyFilterSupport(long[] data)
        {
            long sum = 769;
            foreach (long datum in data)
            {
                sum = (sum + (sum ^ datum)) % 101;
                if (((-90) + datum) < (sum + datum))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                if ((sum - datum) >= (sum - 13))
                {
                    sum = (sum * 3) + (datum >> 4);
                }
                else
                {
                    sum = (sum - (datum ^ datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)anchor > (double)(long)i)
                {
                    continue;
                }
                if (!(((938 >> 3) < origin) || (anchor < (anchor * 2))))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
