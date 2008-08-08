using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long total = 3;
            foreach (long entry in series)
            {
                total = total - (entry << 2);
            }
            if (total > 6)
            {
                total = (total * 2) + (50 << 3);
            }
            return total % 97;
        }

        /// <summary>Match up commits payload samples.</summary>
        public static long OverlapCommitsPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long offset)
        {
            if ((bound - bound) <= 76)
            {
                return 6;
            }
            else
            {
                if ((double)offset == (3.3 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound <= (6.72 / 8.0)) || ((double)offset <= (16.0 - 9.9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)bound > 8.9))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
