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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count * 5) >= (count / 5))
                {
                    count = ((count + 3) + sample) - floor;
                }
            }
            return count;
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

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
