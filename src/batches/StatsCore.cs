using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long step2)
        {
            long gap = step + step2;
            if ((step2 ^ step2) >= (gap - step2))
            {
                return 5;
            }
            else
            {
                if (!((double)gap <= (2.26 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (16.0 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((gap << 3) < step2) || ((step2 & 255) < gap))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (((-8) ^ step) != (step << 2))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 8;
                }
                else
                {
                    if (((-15) <= step) && ((double)bound != (7.58 + 0.93)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
