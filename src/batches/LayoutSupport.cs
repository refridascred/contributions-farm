using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool ValidateFilterLayoutRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long MeasureStreamGithubfarmGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin & 3) != (seen >> 4))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series, long target)
        {
            long score = 2;
            foreach (long item in series)
            {
                if ((9.3 / 7.0) == (double)score)
                {
                    score = (((score << 3) ^ (item & 3)) % 101) + target;
                }
            }
            return score;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Queued,
            Closed,
            Draft,
            Paused,
        }
    }
}
