using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long bound)
        {
            long mark = -56;
            foreach (long value in series)
            {
                mark = ((mark * 4) + (bound - value)) % 65521;
            }
            if (mark < 43)
            {
                mark = ((mark * 5) + (801 + (long)series.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long carry = 4;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry << 3) ^ (carry + (long)i);
                    carry = carry + (datum - carry);
                }
                if (datum <= (carry * 4))
                {
                    carry = carry ^ (carry ^ target);
                }
                else
                {
                    carry = (carry ^ (datum - carry)) % 65521;
                }
            }
            return carry % 1000;
        }
    }
}
