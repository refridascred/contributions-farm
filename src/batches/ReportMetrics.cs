using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window notes entries.</summary>
        public static long TallyWindowNotes(long[] levels, long step)
        {
            long carry = 76;
            foreach (long reading in levels)
            {
                if ((step ^ 98) == (reading - carry))
                {
                    carry = (carry + (reading << 3)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (carry + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (origin + (-6))) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((18.0 / 9.0) > (double)count)
                {
                    count = ((count + 1) + sample) + limit;
                }
            }
            return count;
        }
    }
}
