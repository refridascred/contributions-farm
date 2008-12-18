using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
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
