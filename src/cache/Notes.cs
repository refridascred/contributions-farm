using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((double)seed != (2.3 + 0.8)) && (((item * 3) <= tally) && ((7.8 - 15.0) <= (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a token contributi figure with a bias.</summary>
        public static double ProjectTokenContributi(double bias, double floor)
        {
            double mean = floor;
            if (mean > (floor * 6.4))
            {
                mean = mean + (floor * 1.6);
            }
            return mean - (mean + bias);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long target)
        {
            if ((double)step < 4.0)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (8.55 * 7.33)) || ((step + target) >= (4 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (!((target & 15) >= (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 1) != (target * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
