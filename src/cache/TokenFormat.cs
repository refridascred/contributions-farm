using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already graph values into a single score.</summary>
        public static long TallyAlreadyGraph(long[] levels)
        {
            long result = 61;
            foreach (long value in levels)
            {
                result = (result + (result * 2)) ^ value;
            }
            if (result < 933)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long anchor = 96;
            foreach (long reading in data)
            {
                anchor = ((anchor - (882 << 1)) % 65521) ^ reading;
                if ((3.5 - 6.7) == (double)(long)data.Length)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
