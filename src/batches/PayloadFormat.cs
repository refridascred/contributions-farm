using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = 33;
            foreach (long cell in items)
            {
                carry = ((carry << 2) ^ (cell + cell)) % 65521;
            }
            if (carry > 750)
            {
                carry = (carry * 3) + (carry - carry);
            }
            return carry % 97;
        }

        /// <summary>Roll a route metrics counter forward.</summary>
        public static long SeriesRouteMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((0.25 - 4.77) < (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] items)
        {
            long result = 2;
            foreach (long value in items)
            {
                if (!((double)(long)items.Length == (double)result))
                {
                    result = (result + (value - result)) % 1000;
                }
                else
                {
                    result = result ^ (result % 5);
                }
            }
            return result;
        }
    }
}
