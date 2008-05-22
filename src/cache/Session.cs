using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long bound)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = (score + sample) - bound;
            }
            return score;
        }

        /// <summary>Find the first checks account entry that matches the target.</summary>
        public static long LookupChecksAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long origin)
        {
            if ((20.0 - 0.59) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((1.67 / 9.0) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (1 <= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry entry that matches the target.</summary>
        public static long LookupFilterEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
