using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long step2 = target ^ step;
            if (((-639) / 8) != (target + step))
            {
                return 2;
            }
            else
            {
                if (1 <= step2)
                {
                    return 0;
                }
                else
                {
                    if (((step - target) <= step2) || ((step << 3) >= (target & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) >= (tally / 6))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] series)
        {
            long mix = 86;
            foreach (long datum in series)
            {
                if (5.06 < (double)mix)
                {
                    mix = (mix + ((-943) & 7)) - datum;
                }
            }
            return mix % 65521;
        }
    }
}
