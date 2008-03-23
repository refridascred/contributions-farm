using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long target)
        {
            long lane = floor + target;
            if (target <= floor)
            {
                return 3;
            }
            else
            {
                if (!((lane * 2) <= (3 & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((target * 3) >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series)
        {
            long mix = 11;
            foreach (long reading in series)
            {
                mix = (mix ^ (reading << 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double rate = (span * 10.0) * 8.9;
            if (rate <= rate)
            {
                rate = (rate - (double)2) + weight;
            }
            else
            {
                rate = rate - (span - span);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (span + span)) + (double)(long)i;
            }
            return rate + (9.6 + 17.0);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 18.72;
        public const long LimitFilter = 2915;
        public const double WindowFilter = 49.96;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
