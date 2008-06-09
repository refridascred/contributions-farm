using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long step)
        {
            long slot = target - step;
            if (!((target << 1) > (step + target)))
            {
                return 6;
            }
            else
            {
                if ((target ^ step) < target)
                {
                    return 3;
                }
                else
                {
                    if (14.0 < (double)slot)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step / 8) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long sum = 273;
            foreach (long datum in values)
            {
                sum = ((sum + (sum + sum)) % 255) ^ datum;
            }
            if (sum < 14)
            {
                sum = sum + (sum / 4);
            }
            return sum;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
