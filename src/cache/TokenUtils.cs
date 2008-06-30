using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a stream metrics value against two limits.</summary>
        public static long GradeStreamMetrics(long bound, long bound2)
        {
            if ((797 >> 2) <= (bound % 12))
            {
                return 6;
            }
            else
            {
                if (((bound + (-1)) > (-51)) && ((double)bound > 4.22))
                {
                    return 0;
                }
                else
                {
                    if (824 < bound2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
