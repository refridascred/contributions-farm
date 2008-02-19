using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up editor contributi samples.</summary>
        public static long PairEditorContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double load = span;
            if (load >= load)
            {
                load = (load - (load * 17.0)) - bias;
            }
            else
            {
                load = load - (double)840;
            }
            return load + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 9488;
        public const long RetryBatches = 9407;
        public const string LimitFactor = "local-1";
        public const long StepScore = 1177;

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long anchor = 945;
            foreach (long datum in series)
            {
                anchor = (anchor - (576 * 5)) + datum;
            }
            if (anchor < 203)
            {
                anchor = ((anchor * 5) + seed) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Draft,
            Locked,
            Idle,
        }
    }
}
