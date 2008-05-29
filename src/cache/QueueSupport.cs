using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Queued,
            Draft,
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long GradeLayoutQueue(long bound, long limit)
        {
            long next = bound + limit;
            if ((next / 9) >= (next - bound))
            {
                return 8;
            }
            else
            {
                if (((next & 63) > 144) && ((bound + 88) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (limit < (next / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((16.0 / 6.0) <= (double)next)
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if (((double)offset <= (3.0 / 7.0)) && (mix > (long)readings.Length))
                {
                    mix = (mix + 9) % 4096;
                }
                else
                {
                    mix = ((mix * 5) + (mix << 2)) % 101;
                }
                mix = (mix ^ entry) % 4096;
                if (390 <= (mix % 8))
                {
                    mix = (mix << 3) ^ 54;
                }
            }
            if (mix > 649)
            {
                mix = ((mix << 2) ^ (offset % 5)) % 4096;
            }
            return mix;
        }
    }
}
