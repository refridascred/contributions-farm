using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a token githubfarm reading by value.</summary>
        public static long FindTokenGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long origin)
        {
            long anchor = 209;
            foreach (long entry in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (((anchor << 2) ^ (origin >> 2)) % 4096) - (long)i;
                }
                anchor = ((anchor * 4) + 9) % 65521;
                if (((58 * 3) == (origin + 2)) || (anchor < (entry % 12)))
                {
                    anchor = anchor - (origin & 1);
                }
                else
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
            }
            if (anchor > 20)
            {
                anchor = anchor - (anchor * 2);
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long StepClusterWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 4) + (59 << 2)) % 255) + (long)i2;
                    result = (result ^ (14 & 3)) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long TallyFarmLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen % 64) > 76)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Locate a batch cluster reading by value.</summary>
        public static long LocateBatchClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload notes pair into a bucket.</summary>
        public static long GradePayloadNotes(long limit, long step)
        {
            if (step > (step + step))
            {
                return 6;
            }
            else
            {
                if (limit >= (limit / 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
