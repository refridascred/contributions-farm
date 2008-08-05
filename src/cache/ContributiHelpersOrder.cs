using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if (!((mark << 2) <= (mark & 1)))
                {
                    mark = (((mark << 2) ^ mark) % 4096) ^ cell;
                }
                else
                {
                    mark = mark + bound;
                }
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = (mix ^ (mix & 15)) + origin;
                mix = mix ^ (item << 3);
                if (!((mix - mix) >= mix))
                {
                    mix = ((mix * 3) + (mix % 7)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + item;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 2) >= 11)
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
