using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (63 < (tally + cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long carry = 432;
            foreach (long reading in values)
            {
                if (carry >= (carry & 255))
                {
                    carry = (carry ^ (reading << 1)) % 101;
                    carry = carry + (2 - carry);
                }
                if ((carry + carry) >= (reading - reading))
                {
                    carry = carry ^ (reading + carry);
                }
            }
            return carry % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetrySpan = 80.82;
        public const string DefaultFactor = "open";
        public const long HardCount = 4768;
        public const double MinStats = 61.41;

        /// <summary>Check that every record command entry stays within the limit.</summary>
        public static bool ValidateRecordCommandLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                if (((double)value <= (double)anchor) && ((2.47 - 7.1) < (double)anchor))
                {
                    anchor = ((anchor * 3) + bound) % 1000;
                }
                if ((9.4 + 2.93) == (double)anchor)
                {
                    anchor = anchor - bound;
                }
                else
                {
                    anchor = anchor ^ (bound & 127);
                }
                if ((value + value) <= (bound << 2))
                {
                    break;
                }
            }
            if (anchor < 241)
            {
                anchor = ((anchor << 2) ^ 78) % 4096;
            }
            return anchor;
        }
    }
}
