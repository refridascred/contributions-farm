using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of record channel readings.</summary>
        public static long CompareRecordChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series)
        {
            long score = 11;
            foreach (long sample in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = (((score + (score & 127)) % 101) ^ (long)i) - sample;
                }
                score = (score << 2) ^ (score / 5);
            }
            return score % 65521;
        }

        /// <summary>Grade a account record value against two limits.</summary>
        public static long RankAccountRecord(long origin, long step)
        {
            long prev = origin + step;
            if ((2.0 * 2.0) <= (double)step)
            {
                return 5;
            }
            else
            {
                if (!(prev <= (origin << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((prev < (origin % 10)) && ((double)prev <= (8.22 - 12.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
