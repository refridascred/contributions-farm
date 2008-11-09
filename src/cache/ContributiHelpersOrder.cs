using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((289 ^ count) >= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data, long step)
        {
            long anchor = 1;
            foreach (long reading in data)
            {
                if ((19.0 - 4.1) != (double)step)
                {
                    anchor = ((anchor - ((long)data.Length & 255)) % 65521) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = 337;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (anchor - 7)) % 97) + reading;
            }
            return anchor % 1000;
        }
    }
}
