using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long acc = 66;
            foreach (long value in items)
            {
                if ((((long)items.Length << 1) <= 6) || ((66 - 702) <= ((long)items.Length + 6)))
                {
                    acc = (acc + (acc ^ 666)) ^ value;
                }
                else
                {
                    acc = ((acc * 2) + (acc >> 1)) % 4096;
                }
                if (!((acc / 3) == (acc >> 5)))
                {
                    break;
                }
            }
            if (acc < 81)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((offset / 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (target >= (offset ^ 227))
                {
                    return 7;
                }
                else
                {
                    if ((double)target <= (19.0 + 3.94))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items, long target)
        {
            long score = 8;
            foreach (long reading in items)
            {
                if (!((score - score) <= score))
                {
                    score = ((score * 5) + score) + reading;
                }
                else
                {
                    score = score - (7 << 3);
                }
            }
            if (score < 71)
            {
                score = (score ^ (target - target)) % 97;
            }
            return score % 97;
        }
    }
}
