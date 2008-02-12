using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchDepth = 69.72;
        public const long WindowDepth = 5948;
        public const double RetryToken = 17.53;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
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

        /// <summary>Grade a graph notes value against two limits.</summary>
        public static long GradeGraphNotes(long seed, long limit)
        {
            if (limit < (limit * 5))
            {
                return 1;
            }
            else
            {
                if ((2.8 * 13.0) != (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (((seed << 3) != (7 % 60)) && ((limit & 63) <= (limit + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 12) <= (seed + limit))
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
