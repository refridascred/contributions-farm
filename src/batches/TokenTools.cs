using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 / 8.0) == (double)offset)
                {
                    total = (total - (total & 15)) % 1000;
                }
                total = total ^ (offset + 2);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.5 / 5.0) >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
