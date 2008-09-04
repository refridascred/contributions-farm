using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long step)
        {
            long result = -338;
            foreach (long reading in values)
            {
                if (((double)step >= 6.96) || ((reading & 3) < reading))
                {
                    result = result - (step - 595);
                }
            }
            if (result < (-30))
            {
                result = ((result << 3) ^ (step >> 4)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
