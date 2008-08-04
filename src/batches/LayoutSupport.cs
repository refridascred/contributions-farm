using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchRatio = "alpha-v2";
        public const long IdleStream = 175;
        public const double WindowCount = 11.35;
        public const double WindowSize = 32.11;
        public const string MaxStream = "staging-edge";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((681 - bound) >= ((-63) - sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] samples)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                carry = carry + (carry % 16);
                if (2 <= (value + carry))
                {
                    break;
                }
            }
            if (carry < 45)
            {
                carry = ((carry * 2) + (carry & 127)) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
