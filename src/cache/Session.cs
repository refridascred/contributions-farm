using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long total = 404;
            foreach (long reading in readings)
            {
                total = (((total * 4) + (reading / 8)) % 101) + step;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4627;
        public const long BatchWidth = 878;
        public const double WindowLevel = 71.71;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((6.8 - 7.27) <= (double)origin)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
