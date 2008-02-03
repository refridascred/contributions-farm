using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((mark * 3) <= floor)
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long step)
        {
            if ((double)bound < (double)65)
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
