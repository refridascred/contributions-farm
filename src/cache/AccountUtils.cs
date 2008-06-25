using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                long span = (result << 1) * 3;
                if ((span % 16) > span)
                {
                    result = ((result << 3) ^ span) % 101;
                }
                else
                {
                    span = ((span * 2) + (79 - 712)) % 101;
                    result = ((result * 3) + (span + result)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of window tools entries.</summary>
        public static long TotalWindowTools(long[] values)
        {
            long mark = 97;
            foreach (long datum in values)
            {
                mark = mark + (datum % 60);
                if ((double)mark < (4.4 + 5.56))
                {
                    mark = (mark ^ (mark >> 3)) % 255;
                }
                else
                {
                    mark = mark + (mark + mark);
                }
            }
            if (mark < 652)
            {
                mark = mark - (mark + 91);
            }
            return mark;
        }
    }
}
