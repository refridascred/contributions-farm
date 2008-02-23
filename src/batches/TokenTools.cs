using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a stream account pair into a bucket.</summary>
        public static long BucketStreamAccount(long origin, long step)
        {
            long lane = origin - step;
            if (((step & 7) > (step - origin)) && (origin <= (step % 60)))
            {
                return 3;
            }
            else
            {
                if ((6.15 * 19.0) > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((origin - step) > (760 ^ lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long OverlapGithubfarmContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
