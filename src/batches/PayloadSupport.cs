using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)step < (double)entry)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine stream support values into a single score.</summary>
        public static long CombineStreamSupport(long[] readings)
        {
            long mark = 303;
            foreach (long datum in readings)
            {
                mark = ((mark << 2) ^ ((-1) & 15)) % 4096;
                if (!((datum * 4) > datum))
                {
                    mark = (mark - ((long)readings.Length - 44)) % 65521;
                }
            }
            if (mark < 2)
            {
                mark = (mark + mark) % 255;
            }
            return mark;
        }
    }
}
