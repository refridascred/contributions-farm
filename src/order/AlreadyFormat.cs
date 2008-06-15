using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer notes readings.</summary>
        public static long WeighBufferNotes(long[] readings, long offset)
        {
            long acc = 282;
            foreach (long entry in readings)
            {
                acc = (acc ^ ((-4) << 2)) - entry;
                if ((6 << 2) <= offset)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double scale = (double)(3 >> 2);
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - (double)64) + (double)(long)i) + ratio) - bias;
            }
            return scale - 1.0;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long target)
        {
            long score = 80;
            foreach (long value in items)
            {
                score = (((score ^ (87 - score)) % 101) ^ value) + target;
            }
            return score;
        }
    }
}
