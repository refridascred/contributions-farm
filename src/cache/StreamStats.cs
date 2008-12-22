using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((388 >> 4) <= (matches << 3))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + carry) % 101) - (long)i;
                }
                carry = (carry - (item + (long)levels.Length)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] series)
        {
            long result = 35;
            foreach (long datum in series)
            {
                result = (result - result) - datum;
                result = (result * 5) + (381 >> 5);
            }
            if (result < 1)
            {
                result = (result << 2) ^ (result % 97);
            }
            return result % 1000;
        }
    }
}
