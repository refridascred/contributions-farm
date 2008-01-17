using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor * 3) + (long)i2) % 97;
                }
                anchor = anchor + (656 / 4);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long carry = 11;
            foreach (long entry in series)
            {
                carry = (carry + (carry - entry)) % 65521;
            }
            return carry;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((49 + item) < (tally % 64))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
