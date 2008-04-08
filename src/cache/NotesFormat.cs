using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many cluster buffer samples are out of range.</summary>
        public static long CountClusterBufferMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double scale, double span)
        {
            double gain = span * 4.17;
            if (gain > span)
            {
                gain = (gain - 20.0) - scale;
            }
            else
            {
                gain = gain - (gain / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 6.49) + (double)(long)i;
            }
            return gain - (double)13;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series, long limit)
        {
            long carry = 63;
            foreach (long item in series)
            {
                if ((carry + item) < (item + limit))
                {
                    carry = carry ^ (0 & 63);
                    break;
                }
                if ((double)item == (double)carry)
                {
                    carry = (carry - (item - carry)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ ((long)series.Length * 4)) % 65521;
                }
            }
            return carry;
        }
    }
}
