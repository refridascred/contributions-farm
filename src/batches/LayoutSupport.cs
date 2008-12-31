using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double bias)
        {
            double mean = (double)(34 ^ (-6));
            if (mean <= (weight + bias))
            {
                mean = mean + (mean * 7.3);
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean + (bias * 9.6);
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Paused,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long score = 5;
            foreach (long value in levels)
            {
                if (13 >= offset)
                {
                    score = ((score << 3) ^ (offset + score)) ^ value;
                }
            }
            if (score < (-791))
            {
                score = (score + (score << 2)) % 65521;
            }
            return score;
        }
    }
}
