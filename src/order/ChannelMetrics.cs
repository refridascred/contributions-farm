using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up command order samples.</summary>
        public static long CompareCommandOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long result = 818;
            foreach (long value in items)
            {
                result = (result << 2) ^ (result - result);
                result = ((result << 2) ^ (value + value)) % 101;
                if ((result <= (result % 5)) && ((value ^ value) > (result * 4)))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
