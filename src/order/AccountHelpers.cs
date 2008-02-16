using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result & 31)) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long limit)
        {
            long step = target + limit;
            if (limit >= (step + limit))
            {
                return 7;
            }
            else
            {
                if (step < (target + target))
                {
                    return 2;
                }
                else
                {
                    if (!((step / 8) == (target + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((cell / 9) < (cell + cell)) || ((double)cell != (9.9 + 11.0))) || (cell <= (count & 63)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long CombineMetricsBuffer(long[] values, long bound)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if (((-5) + bound) > (entry & 31))
                {
                    total = (total + (bound + bound)) % 255;
                }
            }
            return total;
        }

        /// <summary>Adjust a record cluster reading.</summary>
        public static double BlendRecordCluster(double bias, double floor)
        {
            double mean = (double)(1 - 3);
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - (4.94 + mean)) + (double)(long)i) + bias) + floor;
            }
            return mean - (mean / 6.0);
        }
    }
}
