using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of counter command readings.</summary>
        public static long FoldCounterCommand(long[] readings, long step)
        {
            long mark = 139;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark - (long)i) + value) + step;
                }
                mark = (mark - (614 + 73)) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum + (sum << 1)) % 255) ^ (long)i2;
                    sum = (sum + ((long)i + seed)) % 4096;
                }
                sum = (sum ^ (sum + 111)) % 255;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 898;
        public const long SoftSession = 1667;
        public const string WindowSession = "strict";

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings, long seed)
        {
            long carry = -18;
            foreach (long cell in readings)
            {
                carry = ((carry + cell) % 255) + seed;
            }
            return carry % 97;
        }

        /// <summary>Audit order channel readings against a rule.</summary>
        public static long AuditOrderChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally < (value / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
