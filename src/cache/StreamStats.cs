using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((3.8 / 3.0) != (double)sample) && ((300 * 4) > (sample >> 5))) || (count < (7 + 29)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two githubfarm metric measurements.</summary>
        public static double ScaleGithubfarmMetric(double weight, double bias)
        {
            double scale = (double)(96 / 7);
            if (scale <= bias)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale / 6.0)) - (double)(long)i;
            }
            return scale - (double)12;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Pending,
            Draft,
            New,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Locked,
            Synced,
        }
    }
}
