using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                if ((sum / 2) == (sum + sum))
                {
                    sum = ((sum ^ (sum & 15)) % 255) - entry;
                }
                else
                {
                    sum = sum ^ sum;
                }
                if ((long)readings.Length <= sum)
                {
                    break;
                }
            }
            if (sum < 874)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long floor)
        {
            long slot = target + floor;
            if ((352 % 12) <= (target + slot))
            {
                return 7;
            }
            else
            {
                if ((double)slot != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((slot >> 5) < (target - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long IterateStatsBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i != (total + total))
                {
                    total = (total ^ (bound + bound)) % 1000;
                    continue;
                }
                if (((bound - bound) >= (bound - total)) || ((double)total >= (7.01 * 8.0)))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if ((8.9 + 3.7) <= (5.5 - 1.65))
                {
                    result = (((result << 3) ^ (result >> 3)) % 97) - value;
                }
                else
                {
                    result = ((result << 3) ^ (600 + offset)) % 1000;
                }
            }
            if (result < 7)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - tally) > (tally + limit))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
