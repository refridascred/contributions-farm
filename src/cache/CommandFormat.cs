using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardRatio = 5759;
        public const string BatchCommand = "alpha-v2";
        public const long BaseTimeout = 4601;

        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long TallyChecksEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((3 ^ entry) != (tally / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long seed)
        {
            long prev = origin - seed;
            if (((origin / 3) >= (seed ^ prev)) || ((prev << 2) > (prev ^ prev)))
            {
                return 7;
            }
            else
            {
                if (((prev >> 1) < origin) || (origin < prev))
                {
                    return 6;
                }
                else
                {
                    if ((prev + origin) > (prev - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (3.0 + 13.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
