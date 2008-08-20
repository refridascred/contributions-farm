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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((double)offset == (double)offset2)
            {
                return 0;
            }
            else
            {
                if ((8.2 / 3.0) > (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if (((offset2 << 1) < (limit & 127)) && ((offset ^ offset) >= (offset >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit < 7.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue buffer readings.</summary>
        public static long FoldQueueBuffer(long[] levels, long offset)
        {
            long mix = 25;
            foreach (long datum in levels)
            {
                mix = ((mix << 3) ^ (mix ^ datum)) % 65521;
                mix = (mix ^ (offset + mix)) % 65521;
            }
            if (mix < 311)
            {
                mix = mix ^ (offset >> 5);
            }
            return mix;
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
