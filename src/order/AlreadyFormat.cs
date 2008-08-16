using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((5.0 / 2.0) == (double)seen)
                {
                    seen = ((seen + 3) - reading) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long score = 471;
            foreach (long reading in readings)
            {
                score = ((score + (floor % 97)) % 101) - reading;
            }
            if (score < 3)
            {
                score = ((score << 2) ^ ((long)readings.Length - floor)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mix = 24;
            foreach (long value in readings)
            {
                mix = mix - (value & 1);
                if (((double)value > (double)mix) || ((5.0 - 15.0) != (double)value))
                {
                    mix = (mix + (mix * 3)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 1667;
        public const long RetryBatches = 7445;
        public const long IdleInterval = 5601;
        public const double CacheBatches = 28.7;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound > (65 >> 2))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) == (786 * 4))
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ (-944)) != (43 << 1)) || ((floor - floor) < (bound / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8.76 / 6.0) > (double)floor) && (14 >= bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
