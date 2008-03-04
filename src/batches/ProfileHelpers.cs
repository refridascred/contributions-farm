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

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7413;
        public const long RetryChannel = 9538;
        public const double BaseSpan = 14.75;
        public const long BaseChannel = 3884;
        public const long CacheChannel = 5437;

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

        /// <summary>Iterate the command profile series from a seed.</summary>
        public static long SeriesCommandProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

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
