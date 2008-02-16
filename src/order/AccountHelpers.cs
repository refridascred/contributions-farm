using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((2.24 - 7.8) <= (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
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
