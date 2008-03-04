using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + matches) <= 40)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order batches entries.</summary>
        public static long TotalOrderBatches(long[] samples, long floor)
        {
            long result = 1;
            foreach (long reading in samples)
            {
                result = (((result << 2) ^ result) % 101) - floor;
                if ((reading / 5) != (reading + (-39)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1632;
        public const long RetryEditor = 3270;
        public const string HardRatio = "staging-v2";
        public const string WindowEditor = "strict";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > (tally + reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
                        {
                            return 0;
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
}
