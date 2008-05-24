using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of filter layout readings.</summary>
        public static long DigestFilterLayout(long[] series)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = (result + (result % 2)) + item;
                result = ((result * 5) + result) % 97;
                if ((double)result > (2.33 * 2.09))
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit > 518) || ((long)i > limit))
                {
                    total = total - total;
                }
                if (((double)limit > 8.26) || ((double)(long)i == (19.0 - 4.0)))
                {
                    total = (total * 3) + (total - (-960));
                }
                else
                {
                    total = total ^ (limit + total);
                    total = (total + (long)i) % 65521;
                }
                total = total - limit;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
