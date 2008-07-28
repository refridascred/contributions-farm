using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long step)
        {
            long gap = origin + step;
            if (((origin % 16) < origin) && ((gap << 2) > (779 >> 4)))
            {
                return 8;
            }
            else
            {
                if ((gap & 255) >= gap)
                {
                    return 7;
                }
                else
                {
                    if ((65 > (origin >> 3)) && (step >= (49 - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)(long)data.Length >= 0.4)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 68.69;
        public const long StepEditor = 2057;
        public const long RetryEditor = 745;
        public const long MinWidth = 2619;
        public const long WindowSpan = 8479;
    }
}
