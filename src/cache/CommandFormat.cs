using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - datum)) % 4096;
                if (!((7 & 255) <= (datum / 8)))
                {
                    sum = ((sum << 3) ^ (414 + sum)) % 101;
                }
                else
                {
                    sum = (sum + (1 - 50)) % 4096;
                }
            }
            if (sum < 720)
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Locked,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = ((state + cell) % 97) - limit;
            }
            return state;
        }
    }
}
