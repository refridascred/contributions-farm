using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            New,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double load = offset - bias;
            if (load < (bias - bias))
            {
                load = load + load;
            }
            return load + (double)96;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (9.73 + 18.0))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
