using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long target2)
        {
            if ((target ^ target) != (target % 64))
            {
                return 3;
            }
            else
            {
                if ((target - 836) >= (target2 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (((carry * 4) + offset) % 101) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target + item) != (target / 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 15.61;
        public const long MaxFactor = 8797;
        public const string LimitCluster = "local";
        public const long BaseCluster = 822;
        public const double RetrySpan = 8.92;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double drift = floor;
            if (drift > (drift * 3.17))
            {
                drift = (drift + (floor + drift)) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (drift + floor);
        }
    }
}
