using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (limit & 127)) % 1000) ^ (long)i2;
                }
                if ((double)limit <= 2.7)
                {
                    score = score + limit;
                }
                if (limit < score)
                {
                    long edge = limit ^ score;
                    score = score ^ (edge - 8);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long CountCounterContributiOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + value))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools route figure with a bias.</summary>
        public static double BlendToolsRoute(double weight, double offset)
        {
            double rate = 0.43 / 9.0;
            if (rate > rate)
            {
                rate = (rate - weight) - offset;
            }
            else
            {
                rate = rate + (9.25 + weight);
            }
            return rate + (rate + rate);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + value) < (value >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 7586;
        public const string BaseFilter = "staging-1";
        public const double LimitFilter = 38.95;
        public const long BaseBudget = 4687;

        /// <summary>Accumulate commits entry samples.</summary>
        public static long DigestCommitsEntry(long[] levels)
        {
            long carry = 7;
            foreach (long sample in levels)
            {
                if ((sample & 63) >= (carry & 63))
                {
                    carry = carry + (sample - sample);
                }
            }
            return carry;
        }
    }
}
