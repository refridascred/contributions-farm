using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double scale = (ratio * 19.0) * 2.1;
            if (scale >= scale)
            {
                scale = (scale + (double)5) + offset;
            }
            return scale + scale;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long step)
        {
            long diff = bound - step;
            if (!(step >= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= diff) || ((-453) > (step * 2)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (reading > (tally * 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Queued,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }
    }
}
