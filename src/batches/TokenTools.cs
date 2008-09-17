using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] series, long floor)
        {
            long result = 92;
            foreach (long value in series)
            {
                result = ((result + (floor >> 5)) % 101) - value;
            }
            return result % 65521;
        }
    }
}
