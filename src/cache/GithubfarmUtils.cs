using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double scale2 = scale + (floor + scale);
            if (scale2 > (8.6 - scale))
            {
                scale2 = scale2 + (scale2 * 2.0);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 + floor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items, long origin)
        {
            long carry = 959;
            foreach (long reading in items)
            {
                carry = (carry ^ origin) ^ reading;
            }
            if (carry < 44)
            {
                carry = (carry * 3) + (carry ^ 805);
            }
            return carry;
        }

        /// <summary>Match up channel profile samples.</summary>
        public static long PairChannelProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
