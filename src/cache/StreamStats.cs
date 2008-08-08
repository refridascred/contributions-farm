using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long offset)
        {
            long span = floor - offset;
            if (3 >= (floor - span))
            {
                return 6;
            }
            else
            {
                if (((1.0 / 2.0) >= (double)floor) || ((double)floor < 6.9))
                {
                    return 1;
                }
                else
                {
                    if (((span * 3) > (offset + 73)) && ((span / 3) <= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span & 7) == (floor + floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
