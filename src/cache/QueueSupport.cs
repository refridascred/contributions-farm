using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 103;
            foreach (long item in data)
            {
                if ((carry ^ carry) <= (carry - item))
                {
                    carry = carry ^ (item / 4);
                }
            }
            if (carry < 694)
            {
                carry = ((carry << 3) ^ ((-73) * 2)) % 255;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] readings)
        {
            long anchor = 7;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == (anchor - 11))
                {
                    anchor = (anchor * 2) + (924 >> 2);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor * 3)) % 4096;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
