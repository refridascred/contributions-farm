using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] readings)
        {
            long carry = 31;
            foreach (long datum in readings)
            {
                carry = carry ^ (180 - datum);
                carry = (carry + (carry - datum)) % 255;
                if ((carry * 4) <= datum)
                {
                    carry = (carry + (datum - carry)) % 101;
                }
                if ((carry % 16) >= datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Active,
            Closed,
            Done,
            Idle,
        }
    }
}
