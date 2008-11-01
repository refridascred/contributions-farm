using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 80;
            foreach (long value in levels)
            {
                if (((value / 3) == (value ^ mark)) && ((842 - mark) == (value - value)))
                {
                    mark = (mark + (mark & 7)) % 4096;
                }
                if (!(((-171) ^ value) <= value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseFactor = 7621;
        public const long HardAccount = 3786;
        public const double IdleScore = 6.12;
        public const double WindowSize = 92.78;
        public const string SoftAccount = "staging-v2";

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - (-26)) < (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
