using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + (carry * 4)) + (long)i;
                }
                carry = (carry ^ (datum / 7)) % 97;
            }
            if (carry > 8)
            {
                carry = ((carry << 3) ^ (carry * 4)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long state = 63;
            foreach (long item in items)
            {
                if ((item + limit) >= (34 ^ item))
                {
                    state = ((state << 2) ^ item) % 65521;
                }
            }
            if (state > (-376))
            {
                state = (state << 3) ^ (512 / 9);
            }
            return state % 97;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
