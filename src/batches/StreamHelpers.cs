using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor - ((-59) / 7);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((floor & 3) == (score >> 3)) && (floor <= ((long)i << 2)))
                {
                    score = score - (floor % 8);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (double)5)
            {
                scale = (scale - (double)244) + span;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - ratio;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 3) >= (95 ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long TallyContributiClusterMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 2) > (595 << 3))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Synced,
            Stale,
            Done,
        }
    }
}
