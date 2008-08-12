using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long bound)
        {
            long cur = step + bound;
            if ((double)bound < (6.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((cur >= (step & 255)) && (7.0 > (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((cur << 3) > (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of report stream readings.</summary>
        public static long DigestReportStream(long[] items)
        {
            long mix = 52;
            foreach (long reading in items)
            {
                mix = (mix - (reading & 1)) % 101;
                if (((mix >> 2) < (reading + (-789))) && ((reading - reading) <= (mix << 2)))
                {
                    mix = ((mix * 2) + (reading << 2)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)score >= (6.82 + 8.96)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
