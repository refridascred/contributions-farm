using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long total = 873;
            foreach (long sample in data)
            {
                total = total ^ 6;
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 2) ^ (sample - sample)) % 97) ^ (long)i;
                }
                if ((double)total >= (8.59 + 2.76))
                {
                    total = (total ^ (total & 127)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count >= ((-44) >> 3))
                {
                    count = ((count + 3) - datum) - bound;
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
