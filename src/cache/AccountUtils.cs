using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 5) + mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + (long)i) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm tools measurements.</summary>
        public static double ScaleGithubfarmTools(double gain, double span)
        {
            double load = gain - (span / 7.0);
            if (load < 5.6)
            {
                load = load - span;
            }
            else
            {
                load = load - load;
            }
            return load + span;
        }
    }
}
