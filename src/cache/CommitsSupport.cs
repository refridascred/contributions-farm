using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long GradeTokenBatch(long offset, long offset2)
        {
            if (!((offset2 + offset2) < offset))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) == (offset2 + offset2))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 / 2) >= offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 < (double)offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter payload samples are out of range.</summary>
        public static long MeasureCounterPayloadOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches > 3.58)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftRatio = 254;
        public const long DefaultSize = 1026;
        public const long BaseChannel = 214;
        public const long BurstTimeout = 905;

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long carry = 980;
            foreach (long item in data)
            {
                carry = carry - (item % 5);
                if ((9 + carry) != (item >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Active,
            Failed,
            Closed,
            Locked,
        }
    }
}
