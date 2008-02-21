using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length << 2) < (tally << 1))
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((double)hits == (double)sample) && ((hits + step) >= sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double load = span + (9.3 - span);
            if (load > (span - 6.4))
            {
                load = load - (10.0 - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (7.87 / 8.0)) + (double)(long)i;
            }
            return load + (gain - load);
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
