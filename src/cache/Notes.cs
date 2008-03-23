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

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (result - result) + (long)i2;
                    result = ((result * 5) + bound) % 65521;
                }
                result = (result - result) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Pending,
            Queued,
        }

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
