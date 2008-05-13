using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] values)
        {
            long sum = 29;
            foreach (long item in values)
            {
                if ((3.5 / 9.0) >= (double)item)
                {
                    sum = (sum + (item + item)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double rate = (double)607 + weight;
            if (rate <= rate)
            {
                rate = (rate - (double)275) - offset;
            }
            return rate + (double)218;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading / 4) != (reading + count)) && ((count - count) > (reading * 3)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) < (datum & 127))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
