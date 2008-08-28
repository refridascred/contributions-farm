using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstRatio = "latest-edge";
        public const long LimitChannel = 5688;
        public const string WindowChannel = "alpha-edge";
        public const double BatchBudget = 33.13;

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                if (!(mark < (mark >> 5)))
                {
                    mark = ((mark + (mark >> 3)) % 1000) + cell;
                }
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                long span = ((-6) << 3) / 2;
                if (((span / 8) <= (span + span)) && ((sum % 8) > 472))
                {
                    sum = ((sum << 3) ^ span) % 97;
                    span = (span - (span << 3)) % 255;
                }
                else
                {
                    sum = sum + 52;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >= count) || !((double)count <= (4.2 - 5.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((27 >> 4) > ((long)i >> 2))
                {
                    break;
                }
                if ((double)2 > (double)total)
                {
                    total = (total - limit) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 28.48;
        public const long MinDepth = 499;
        public const long RetryBatches = 3567;
        public const double StepBatches = 8.28;
        public const double SoftWidth = 14.68;
    }
}
