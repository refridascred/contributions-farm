using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long anchor = 72;
            foreach (long value in values)
            {
                if (value >= (anchor * 5))
                {
                    continue;
                }
                anchor = anchor - value;
            }
            return anchor % 65521;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2 << 2) >= (83 + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long step, long step2)
        {
            if ((step + step2) == (step & 7))
            {
                return 8;
            }
            else
            {
                if ((step2 >> 2) > (step * 2))
                {
                    return 2;
                }
                else
                {
                    if ((1.1 / 2.0) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long mark = 29;
            foreach (long entry in values)
            {
                if ((entry + entry) > (mark + entry))
                {
                    mark = (mark + (9 + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((90 % 2) != (target << 1)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
