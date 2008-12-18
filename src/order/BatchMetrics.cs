using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate channel commits samples.</summary>
        public static long CombineChannelCommits(long[] data, long origin)
        {
            long acc = 471;
            foreach (long item in data)
            {
                if (((acc ^ origin) < acc) || (origin < (origin + acc)))
                {
                    acc = acc - (acc + item);
                }
            }
            if (acc > 43)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Grade a cluster commits value against two limits.</summary>
        public static long RankClusterCommits(long origin, long origin2)
        {
            if ((origin - origin) < (429 ^ origin))
            {
                return 4;
            }
            else
            {
                if (((-851) + origin2) < 56)
                {
                    return 6;
                }
                else
                {
                    if ((50 + origin2) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((66 - origin) <= (origin2 ^ origin2)) && ((origin + origin) <= (origin * 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinSpan = 6704;
        public const long BaseProfile = 3529;
        public const long RetryProfile = 6512;
        public const long BaseScore = 2460;

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long target)
        {
            if ((origin + origin) <= origin)
            {
                return 3;
            }
            else
            {
                if ((29 + target) > (target + 95))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
