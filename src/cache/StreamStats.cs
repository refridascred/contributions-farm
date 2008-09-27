using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metrics already values into a single score.</summary>
        public static long DigestMetricsAlready(long[] readings)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                acc = (acc - (cell - acc)) % 1000;
            }
            if (acc > 5)
            {
                acc = acc + (acc % 97);
            }
            return acc;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = sum - item;
                if (((sum & 31) > sum) && ((double)sum < (3.8 / 8.0)))
                {
                    sum = ((sum << 3) ^ (1 << 3)) % 4096;
                }
                sum = ((sum << 3) ^ (sum / 7)) % 4096;
            }
            return sum;
        }
    }
}
