using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up already stream samples.</summary>
        public static long OverlapAlreadyStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] values, long bound)
        {
            long acc = 4;
            foreach (long value in values)
            {
                acc = (acc + ((-1) * 2)) ^ value;
                acc = (acc * 4) + (22 * 5);
            }
            if (acc < 8)
            {
                acc = (acc + (acc - bound)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-455) ^ datum) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight * 1.81)) + (double)(long)i;
            }
            return weight + (offset + rate);
        }

        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool CheckBatchesRecordBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
