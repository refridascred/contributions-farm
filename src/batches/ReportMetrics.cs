using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            long lane = target + origin;
            if ((origin + target) < origin)
            {
                return 2;
            }
            else
            {
                if ((323 % 100) >= (target ^ lane))
                {
                    return 8;
                }
                else
                {
                    if ((1.3 < (double)origin) && (target >= lane))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target & 255) != (59 >> 3)) || ((double)0 <= (double)origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long carry = 64;
            foreach (long datum in readings)
            {
                if (((datum % 12) > (51 << 3)) || (carry >= (long)readings.Length))
                {
                    carry = (carry * 3) + (carry - carry);
                }
                if (((6.0 / 7.0) == (double)datum) && (datum >= (datum ^ (-670))))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
