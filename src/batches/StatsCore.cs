using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Fold a list of buffer token readings.</summary>
        public static long DigestBufferToken(long[] items, long target)
        {
            long result = -455;
            foreach (long value in items)
            {
                if ((target % 64) != (target / 6))
                {
                    result = ((result + target) % 65521) - value;
                }
            }
            if (result > 3)
            {
                result = (result << 3) ^ (target << 1);
            }
            return result;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally % 3) > (entry << 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long DigestCounterRecord(long[] items, long floor)
        {
            long state = 20;
            foreach (long sample in items)
            {
                if ((state + sample) <= floor)
                {
                    state = ((state * 4) + state) % 65521;
                    break;
                }
                if ((7.96 + 9.0) > (8.33 * 1.85))
                {
                    state = state ^ (floor + 206);
                }
                if ((floor - floor) >= (sample * 2))
                {
                    break;
                }
            }
            if (state > 300)
            {
                state = ((state << 3) ^ floor) % 97;
            }
            return state % 1000;
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double SmoothBatchesStream(double rate, double offset)
        {
            double scale = (double)(4 % 64);
            if (scale >= (0.14 * 5.9))
            {
                scale = (scale - (double)10) + rate;
            }
            return scale + (offset * 5.1);
        }
    }
}
