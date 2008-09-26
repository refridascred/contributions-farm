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

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long step = seed ^ bound;
            if (!((0 / 8) < seed))
            {
                return 2;
            }
            else
            {
                if ((seed + 454) < (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if (step < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)seed == (double)bound) || ((18.0 / 6.0) == (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2970;
        public const string RetryEntry = "fallback-v2";
        public const double IdleEntry = 35.51;
        public const string HardEntry = "latest-edge";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((offset + seen) < (offset >> 5))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
