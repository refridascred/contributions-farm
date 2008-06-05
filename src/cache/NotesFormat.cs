using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 & 255) >= tally)
                {
                    tally = ((tally + 2) ^ datum) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series)
        {
            long mix = 4;
            foreach (long value in series)
            {
                if (((mix - value) == (mix * 2)) && ((double)value > (4.01 - 16.0)))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                    continue;
                }
                if ((value - value) <= (793 + value))
                {
                    mix = (mix + (115 >> 5)) % 1000;
                }
            }
            if (mix < 49)
            {
                mix = (mix - (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
