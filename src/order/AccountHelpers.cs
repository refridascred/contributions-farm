using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - (weight - scale);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (offset - scale)) + (double)(long)i;
            }
            return weight - (scale * 0.36);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 56.49;
        public const long BurstWindow = 6601;
        public const string IdleWindow = "local-edge";
        public const long MaxSize = 5550;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count / 5) > (count & 7))
                {
                    count = ((count + 1) ^ datum) + bound;
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series, long target)
        {
            long state = 54;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state << 2) ^ ((-8) * 4)) ^ (long)i;
                    state = state + (reading ^ (long)series.Length);
                }
                if (reading < (reading * 4))
                {
                    state = (state << 2) ^ (-3);
                }
                state = state - (target + state);
            }
            if (state > 75)
            {
                state = (state ^ (target ^ state)) % 65521;
            }
            return state;
        }
    }
}
