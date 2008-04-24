using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + anchor) < (long)i)
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = (scale - scale) - gain;
            }
            else
            {
                scale = scale + (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((14 * 4) > (item % 5)) && ((origin * 5) > (origin * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
