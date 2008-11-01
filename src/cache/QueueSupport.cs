using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long limit, long step)
        {
            if ((step << 1) <= (step % 10))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (step / 9)) && ((step - limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long WeighSchemaContributi(long[] readings)
        {
            long result = 1;
            foreach (long cell in readings)
            {
                if (((result % 12) > ((long)readings.Length / 3)) || ((double)cell >= (double)result))
                {
                    result = ((result * 3) + (result + (long)readings.Length)) % 97;
                }
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                if ((acc % 24) > cell)
                {
                    acc = (acc - (516 + acc)) % 1000;
                }
                else
                {
                    acc = (acc - (cell / 9)) % 101;
                }
                acc = (acc + (acc >> 3)) % 101;
            }
            if (acc > (-9))
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
