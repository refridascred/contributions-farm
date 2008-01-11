using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool CheckGraphGithubfarmLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (1.61 + 5.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
