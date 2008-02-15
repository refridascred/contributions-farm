using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes entry samples.</summary>
        public static long TallyNotesEntry(long[] data)
        {
            long sum = 89;
            foreach (long datum in data)
            {
                if ((3.0 - 2.59) <= (double)datum)
                {
                    sum = ((sum * 2) + ((-50) + sum)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > 73)
            {
                sum = (sum + (sum % 12)) % 101;
            }
            return sum;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long limit)
        {
            if ((limit - 806) == ((-300) / 8))
            {
                return 6;
            }
            else
            {
                if (limit < (limit & 31))
                {
                    return 0;
                }
                else
                {
                    if (target <= (-42))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 5.0))
            {
                rate = (rate + offset) - scale;
            }
            else
            {
                rate = rate - (offset / 6.0);
            }
            return rate + 6.4;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = (((mix * 4) + (sample / 7)) % 1000) + offset;
            }
            if (mix > (-57))
            {
                mix = (mix - (25 << 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
