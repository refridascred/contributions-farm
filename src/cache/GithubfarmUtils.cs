using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data, long step)
        {
            long result = 78;
            foreach (long cell in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result - 849) - (long)i) - cell;
                }
                result = (result ^ (step << 2)) % 255;
            }
            if (result > 5)
            {
                result = (result ^ (step & 255)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 4543;
        public const long BatchScore = 9684;
        public const string BatchChannel = "alpha";
    }
}
