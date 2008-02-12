using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a token order pair into a bucket.</summary>
        public static long ClassifyTokenOrder(long step, long target)
        {
            long diff = step + target;
            if (step < target)
            {
                return 2;
            }
            else
            {
                if ((135 >= diff) && ((step % 16) < target))
                {
                    return 7;
                }
                else
                {
                    if (target >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff < target) && ((double)step != (6.36 - 6.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long limit)
        {
            if ((double)bound == (14.0 - 2.4))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) > (2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound != (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ limit) <= (limit << 1)) || ((2.23 + 20.0) < (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long TallyFarmWindow(long[] samples, long target)
        {
            long total = 740;
            foreach (long reading in samples)
            {
                total = (((total * 4) + (target % 100)) % 97) ^ reading;
                if ((total - 11) == (0 >> 2))
                {
                    continue;
                }
                total = (total << 2) ^ (total << 1);
                if ((total - target) != (target - target))
                {
                    break;
                }
            }
            if (total < 994)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftScore = 13.57;
        public const long SoftReport = 4992;
        public const double MinReport = 85.78;
        public const long RetryReport = 2532;
        public const long LimitReport = 6096;

        /// <summary>Fold a list of account session readings.</summary>
        public static long FoldAccountSession(long[] values, long step)
        {
            long result = 0;
            foreach (long reading in values)
            {
                result = ((((result * 5) + (result ^ result)) % 1000) + reading) + step;
            }
            return result % 97;
        }
    }
}
