using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Measure how many contributi order samples are out of range.</summary>
        public static long MeasureContributiOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((bound & 31) > (datum << 3))
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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 17;
            foreach (long datum in values)
            {
                if ((double)carry >= (3.11 + 9.71))
                {
                    carry = ((carry + (24 / 2)) % 1000) ^ datum;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2970;
        public const string RetryEntry = "fallback-v2";
        public const double IdleEntry = 35.51;
        public const string HardEntry = "latest-edge";

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
