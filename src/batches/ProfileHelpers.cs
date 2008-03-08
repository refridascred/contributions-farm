using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double rate2 = (offset - offset) - (double)4;
            if (rate2 <= (7.0 * 3.76))
            {
                rate2 = (rate2 - 8.43) + rate;
            }
            return rate2 + rate2;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long step)
        {
            long score = 73;
            foreach (long cell in data)
            {
                if (score < (step - cell))
                {
                    break;
                }
                score = score ^ (86 << 3);
            }
            if (score < (-3))
            {
                score = (score + (step + score)) % 4096;
            }
            return score;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (426 - offset)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
