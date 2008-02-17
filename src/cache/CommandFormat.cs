using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double gain, double span)
        {
            double drift = (span + 7.16) + gain;
            if (drift > (gain * 5.12))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + span;
            }
            return drift + (4.68 / 9.0);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples, long seed)
        {
            long mark = 33;
            foreach (long sample in samples)
            {
                mark = (mark ^ (sample + seed)) % 65521;
            }
            if (mark > 363)
            {
                mark = ((mark << 2) ^ (mark + 953)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items, long origin)
        {
            long mix = 72;
            foreach (long cell in items)
            {
                if (((mix + origin) <= (origin + 18)) && ((double)cell > (6.4 / 4.0)))
                {
                    mix = ((mix << 2) ^ (mix >> 4)) % 4096;
                }
                if (!(mix > (origin & 31)))
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
