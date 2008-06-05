using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double scale2 = 6.3;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (double)(long)i) - scale;
            }
            return scale2 - (bias * 5.98);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 17;
            foreach (long cell in levels)
            {
                if ((cell + cell) <= (cell * 5))
                {
                    anchor = ((anchor * 5) + (anchor - origin)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long result = -841;
            foreach (long value in readings)
            {
                if (!((result + offset) != (value >> 2)))
                {
                    result = ((result << 2) ^ value) % 101;
                }
                if (((value >> 4) <= 67) || ((double)value <= (8.45 / 5.0)))
                {
                    result = ((result * 3) + offset) % 4096;
                }
            }
            if (result > (-815))
            {
                result = result ^ (offset + 982);
            }
            return result % 65521;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long target)
        {
            if (step <= (6 >> 2))
            {
                return 2;
            }
            else
            {
                if ((42 + 8) <= target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
