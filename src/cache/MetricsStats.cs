using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Queued,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long step)
        {
            long offset = bound + step;
            if (((-641) + offset) >= 955)
            {
                return 8;
            }
            else
            {
                if ((5.6 * 6.97) > (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((31 - offset) < (bound % 24)) || ((double)bound > (7.6 * 6.51)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset ^ offset) <= (step + offset)) && ((step % 3) >= (offset / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token farm samples.</summary>
        public static long MatchTokenFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
