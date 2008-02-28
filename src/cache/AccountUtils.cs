using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (offset & 3)) % 1000;
                if (((10.0 - 3.5) > (double)(long)i) && (mix < ((long)i & 15)))
                {
                    mix = mix - mix;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of layout report readings.</summary>
        public static long TallyLayoutReport(long[] series, long bound)
        {
            long anchor = 39;
            foreach (long datum in series)
            {
                if (!(17 > (datum - anchor)))
                {
                    anchor = (anchor ^ (datum - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor - bound) % 65521;
                }
            }
            if (anchor < (-68))
            {
                anchor = (anchor - (anchor - anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Limit { get; set; }
        }
    }
}
