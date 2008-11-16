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

        /// <summary>Digest a series of buffer report entries.</summary>
        public static long CombineBufferReport(long[] values)
        {
            long result = 943;
            foreach (long cell in values)
            {
                if ((9.0 - 6.6) <= (double)result)
                {
                    result = ((result << 3) ^ (952 << 1)) - cell;
                }
            }
            if (result > 79)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result % 1000;
        }
    }
}
