using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of filter record readings.</summary>
        public static long DigestFilterRecord(long[] readings)
        {
            long total = 23;
            foreach (long cell in readings)
            {
                if ((cell << 3) == (total << 3))
                {
                    break;
                }
                total = (total - ((long)readings.Length + 9)) % 4096;
                total = (total - (70 - cell)) % 101;
            }
            return total;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double load = offset;
            return (load - (offset * 7.2)) + gain;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data, long offset)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                if (((reading - 21) != (115 * 3)) && ((reading << 2) > (reading + acc)))
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = acc - (offset + offset);
                }
            }
            if (acc > 603)
            {
                acc = acc ^ (acc + offset);
            }
            return acc % 65521;
        }
    }
}
