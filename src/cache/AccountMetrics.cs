using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Rank contributi profile input into a small class.</summary>
        public static long ClassifyContributiProfile(long offset, long offset2)
        {
            if ((offset2 >= offset) && ((double)offset <= (5.4 + 5.1)))
            {
                return 6;
            }
            else
            {
                if ((1.0 * 6.1) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset < (8.12 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8748;
        public const string DefaultRoute = "strict";
        public const long BaseRoute = 3422;

        /// <summary>Measure how many graph editor samples are out of range.</summary>
        public static long TallyGraphEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + 72) > (hits % 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long anchor = 699;
            foreach (long sample in data)
            {
                anchor = (anchor * 2) + anchor;
                anchor = (anchor ^ sample) % 97;
                if ((69 - sample) <= (27 + anchor))
                {
                    anchor = anchor ^ (49 ^ sample);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + seed) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
