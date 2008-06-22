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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) >= (tally / 3))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
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

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepTimeout = 8645;
        public const long LimitStream = 478;
        public const double WindowStream = 95.02;

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
