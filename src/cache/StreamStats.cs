using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long DeriveGithubfarmProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + ((long)i + 713)) % 1000;
                sum = ((sum << 2) ^ (sum + offset)) % 101;
                if ((offset + sum) == (offset + offset))
                {
                    sum = ((sum << 3) ^ (offset / 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate already buffer readings against a bound.</summary>
        public static bool CheckAlreadyBufferBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double bias, double offset)
        {
            double ratio = bias;
            return ratio + offset;
        }
    }
}
