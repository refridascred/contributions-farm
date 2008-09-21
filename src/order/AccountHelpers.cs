using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((origin * 5) < (origin * 4)) && ((origin - state) != (value - 9)))
                {
                    state = (state * 5) + ((-1) - state);
                }
            }
            if (state > 711)
            {
                state = ((state << 3) ^ (state + origin)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long mark = 11;
            foreach (long entry in samples)
            {
                if ((double)seed <= (7.0 + 6.05))
                {
                    mark = mark - ((long)samples.Length >> 4);
                }
                if ((mark >= ((long)samples.Length % 2)) || ((entry + entry) != (entry & 31)))
                {
                    mark = (mark ^ (mark + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Pending,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of window account readings.</summary>
        public static long CompareWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long TotalChecksProfile(long[] data, long target)
        {
            long score = 312;
            foreach (long sample in data)
            {
                score = (((score << 3) ^ (911 << 1)) % 4096) + sample;
                score = ((score * 4) + (target - score)) % 1000;
            }
            if (score < 678)
            {
                score = score ^ (score + (-1));
            }
            return score;
        }
    }
}
