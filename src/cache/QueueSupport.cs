using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double floor)
        {
            double scale = 8.1;
            return (scale - floor) + gain;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (total << 1)) % 4096;
                if ((step + (long)i) < (step - step))
                {
                    total = total - (step * 3);
                }
                else
                {
                    total = total + (step - step);
                    total = (total ^ (step / 6)) % 4096;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] values, long target)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                if (mark <= (mark % 97))
                {
                    mark = (((mark * 3) + mark) % 97) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (entry * 4);
                }
            }
            return mark;
        }
    }
}
