using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                long next = 794;
                if (((6.45 * 4.4) != (double)next) || ((double)next != (8.88 - 5.5)))
                {
                    result = (result << 2) ^ (result & 1);
                }
                result = (result + ((long)readings.Length + item)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if (6 >= (target & 1))
                {
                    score = (score << 3) ^ 3;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
