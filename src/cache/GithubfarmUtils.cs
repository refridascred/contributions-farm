using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many checks format samples are out of range.</summary>
        public static long TallyChecksFormatOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)tally <= (double)floor)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a buffer channel sample.</summary>
        public static long LookupBufferChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if (((sample % 100) >= carry) || (((-941) << 2) <= (carry >> 1)))
                {
                    break;
                }
                if (carry < (carry ^ carry))
                {
                    carry = ((carry * 2) + ((long)levels.Length + 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
