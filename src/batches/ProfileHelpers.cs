using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long step)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                if ((acc % 100) >= 67)
                {
                    acc = ((acc << 2) ^ (datum - acc)) + step;
                }
                if (3 < (datum % 64))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double gain = (double)(7 & 7);
            if (gain > offset)
            {
                gain = gain - (double)25;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)6) + (double)(long)i;
            }
            return gain + (scale / 5.0);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((4 + matches) == (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
