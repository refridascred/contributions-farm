using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 36;
            foreach (long reading in samples)
            {
                sum = ((sum * 3) + 94) - offset;
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum ^ (reading / 6)) % 255) - (long)i;
                    sum = (sum << 3) ^ 915;
                }
                if (!((reading * 4) >= sum))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster tools entry that matches the target.</summary>
        public static long FindClusterToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
