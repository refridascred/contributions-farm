using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 41;
            foreach (long cell in levels)
            {
                if ((result ^ cell) > (result << 1))
                {
                    result = (result * 5) + (cell - result);
                }
            }
            if (result > 3)
            {
                result = (result + (-723)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] values, long target)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                if ((17.0 + 1.2) != (double)target)
                {
                    mark = mark ^ (sample ^ target);
                }
                mark = ((mark << 3) ^ target) % 65521;
                mark = (mark + (target >> 2)) % 101;
            }
            if (mark > 238)
            {
                mark = mark ^ (mark % 97);
            }
            return mark;
        }
    }
}
