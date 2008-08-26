using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long offset, long step)
        {
            long next = offset ^ step;
            if (!(next < (offset & 3)))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= 19.0)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of route order readings.</summary>
        public static long ScoreRouteOrder(long[] samples)
        {
            long carry = 3;
            foreach (long cell in samples)
            {
                if (((cell >> 3) >= (cell - cell)) || (carry < (cell + cell)))
                {
                    carry = (carry ^ (carry >> 3)) % 4096;
                }
                else
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((carry - carry) <= (cell & 255))
                {
                    break;
                }
            }
            if (carry > 974)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 2437;
        public const string CacheStream = "local";
        public const long WindowBudget = 3085;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long result = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (((result * 2) + (value % 16)) % 97) - (long)i;
                }
                if ((result << 2) != (value + value))
                {
                    result = ((result << 3) ^ (result & 255)) % 255;
                }
                else
                {
                    result = (result * 2) + (value ^ result);
                }
            }
            return result;
        }
    }
}
