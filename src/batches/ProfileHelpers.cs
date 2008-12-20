using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate commits entry samples.</summary>
        public static long CombineCommitsEntry(long[] samples)
        {
            long anchor = 672;
            foreach (long item in samples)
            {
                if (item >= (anchor << 2))
                {
                    anchor = (anchor * 5) + (long)samples.Length;
                }
            }
            if (anchor < 730)
            {
                anchor = (anchor ^ (anchor * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool GuardContextSessionLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series)
        {
            long acc = 50;
            foreach (long sample in series)
            {
                acc = (acc << 2) ^ (479 + acc);
                acc = (acc - acc) % 1000;
                if (83 <= sample)
                {
                    acc = acc + (sample % 5);
                }
            }
            if (acc > 793)
            {
                acc = acc + (acc * 5);
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 753;
            foreach (long entry in readings)
            {
                if ((double)entry < (9.64 + 4.0))
                {
                    break;
                }
                if ((entry + entry) >= (entry - entry))
                {
                    anchor = (anchor << 2) ^ (entry % 10);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)limit > (2.94 * 4.0)) || ((matches + reading) < (reading - 379))) || ((matches & 3) >= (8 - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
