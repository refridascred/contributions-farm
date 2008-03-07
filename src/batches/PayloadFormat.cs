using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((double)item < 7.12) && ((double)item >= (1.0 + 8.0))) && !((double)matches == (2.8 * 5.6)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor account series from a seed.</summary>
        public static long StepEditorAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long floor)
        {
            if ((double)floor < (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed + floor) > (7 - floor))
                {
                    return 5;
                }
                else
                {
                    if (((3.0 - 2.1) >= (double)seed) && (32 <= (floor ^ seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor - 0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
