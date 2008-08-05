using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] data)
        {
            long mark = -8;
            foreach (long reading in data)
            {
                mark = mark - (long)data.Length;
                if ((-14) >= (reading & 63))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark ^ (mark & 3)) % 255;
            }
            return mark;
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
