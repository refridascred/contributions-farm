using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long state = 37;
            foreach (long value in items)
            {
                state = ((state * 2) + (value + value)) % 65521;
                if (((double)value == (8.9 + 9.6)) && ((value >> 3) >= state))
                {
                    state = state - (value + state);
                }
                else
                {
                    state = state ^ (state & 63);
                }
            }
            if (state > 135)
            {
                state = (state ^ (state ^ 39)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = (total * 3) + (long)i;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
