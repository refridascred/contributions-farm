using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batches token value.</summary>
        public static double AdjustBatchesToken(double scale, double offset)
        {
            double ratio = (5.2 * 6.68) / 3.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (scale / 6.0)) - (double)(long)i;
            }
            return ratio - (9.7 + offset);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values)
        {
            long sum = -233;
            foreach (long cell in values)
            {
                if (((double)cell > (double)sum) || ((sum >> 4) <= (cell + sum)))
                {
                    sum = sum + (39 & 31);
                }
                else
                {
                    sum = ((sum * 5) + (cell + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Match up report entry samples.</summary>
        public static long OverlapReportEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
