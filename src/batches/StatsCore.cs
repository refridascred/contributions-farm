using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                long delta = (carry * 5) + (step % 60);
                carry = (carry * 2) + delta;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long result = 5;
            foreach (long reading in series)
            {
                if ((result >> 2) <= result)
                {
                    result = ((result << 2) ^ (result + result)) + reading;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate checks channel samples.</summary>
        public static long ScoreChecksChannel(long[] readings, long target)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if (target > (1 & 255))
                {
                    mix = (mix ^ (target ^ datum)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (target - target);
                }
                if ((double)(long)readings.Length >= (double)datum)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix * 4) + (23 + mix);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinInterval = 97.17;
        public const long MinSchema = 903;
        public const double WindowSchema = 33.89;
        public const long LimitSchema = 2801;

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double rate = scale;
            if (rate < (double)99)
            {
                rate = (rate + (double)90) - offset;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            return rate - (double)(-727);
        }
    }
}
