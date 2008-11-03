using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next notes githubfarm value from a seed.</summary>
        public static long RollNotesGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = ((mix ^ (mix - step)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + matches) < (seed + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data)
        {
            long result = 8;
            foreach (long item in data)
            {
                result = (result << 3) ^ (290 & 255);
                if ((item << 1) < (result + item))
                {
                    break;
                }
                result = (result + (result ^ result)) % 97;
                if ((double)item <= 20.0)
                {
                    break;
                }
            }
            return result;
        }
    }
}
