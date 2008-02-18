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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long origin, long limit)
        {
            if (((double)origin > (17.0 + 15.0)) && (limit < origin))
            {
                return 7;
            }
            else
            {
                if (((limit * 2) >= (limit & 7)) && ((8.11 / 2.0) > (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (!((15 >> 5) != (limit + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((8.3 - 8.7) != (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
