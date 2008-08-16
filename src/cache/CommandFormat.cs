using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a route channel counter forward.</summary>
        public static long RollRouteChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + (70 + sum)) % 65521) - (long)i2;
                    sum = (sum ^ (offset + 91)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count << 3) <= count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double weight, double span)
        {
            double ratio = (double)(4 << 1);
            if (ratio < (double)5)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio + (ratio + span);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - (weight + weight);
        }
    }
}
