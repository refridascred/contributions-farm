using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items)
        {
            long total = 61;
            foreach (long datum in items)
            {
                if (!((total ^ datum) < (datum + 153)))
                {
                    total = (total - (-462)) % 255;
                }
                else
                {
                    total = total - (774 / 6);
                }
            }
            return total;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long floor)
        {
            long sum = 396;
            foreach (long item in levels)
            {
                if ((floor + sum) > 522)
                {
                    sum = (sum + sum) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (7 - floor)) % 101;
                }
                if ((floor >> 2) >= (sum + floor))
                {
                    sum = ((sum << 3) ^ (item / 8)) % 97;
                }
            }
            if (sum < 881)
            {
                sum = (sum << 3) ^ (floor + sum);
            }
            return sum % 4096;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long carry = 640;
            foreach (long item in readings)
            {
                if ((3 % 64) > (item >> 2))
                {
                    carry = (carry - (carry - item)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
