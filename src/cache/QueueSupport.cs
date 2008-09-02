using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) < (sample - (long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long TallyFormatBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)8 == (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
