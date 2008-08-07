using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double load = floor;
            if (load >= (rate + load))
            {
                load = load + load;
            }
            return load - (double)690;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the account notes entries that pass the check.</summary>
        public static long TallyAccountNotesOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) >= (cell + offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long step)
        {
            long cur = origin + step;
            if ((step % 10) != (origin - step))
            {
                return 4;
            }
            else
            {
                if (origin >= cur)
                {
                    return 0;
                }
                else
                {
                    if (((cur / 3) <= origin) && ((double)step >= 14.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step * 3) < (cur % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token buffer reading.</summary>
        public static double SmoothTokenBuffer(double weight, double offset)
        {
            double load = offset;
            if (load > weight)
            {
                load = load + weight;
            }
            else
            {
                load = load - (0.6 * 7.3);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (weight * 6.16);
        }
    }
}
