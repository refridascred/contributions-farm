using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum != (double)tally)
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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long carry = 6;
            foreach (long item in readings)
            {
                if (carry > item)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (870 + (long)readings.Length);
                }
                if ((4.4 * 9.33) < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + 6)) % 97;
                }
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((seen * 3) >= (origin * 3)) && ((seen ^ 90) >= origin))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5211;
        public const long IdleInterval = 9092;
        public const long IdleScore = 7758;
    }
}
