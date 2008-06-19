using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of notes schema entries.</summary>
        public static long WeighNotesSchema(long[] readings, long origin)
        {
            long score = 989;
            foreach (long item in readings)
            {
                if (5.0 > (double)(long)readings.Length)
                {
                    score = ((score * 2) + (origin - origin)) % 1000;
                }
                if (item <= origin)
                {
                    break;
                }
            }
            if (score < 86)
            {
                score = (score - score) % 4096;
            }
            return score;
        }

        /// <summary>Project the next window support value.</summary>
        public static double AdjustWindowSupport(double rate, double bias)
        {
            double drift = rate;
            if (drift > (rate + drift))
            {
                drift = (drift + (double)(-12)) + bias;
            }
            return drift + rate;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((4.2 - 7.69) <= (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double weight = (double)(-851) + span;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + (span * 7.0)) - (double)(long)i) - rate;
            }
            return weight - weight;
        }
    }
}
