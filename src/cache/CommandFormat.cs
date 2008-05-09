using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long score = 57;
            foreach (long cell in readings)
            {
                score = ((score * 5) + 1) % 101;
                if ((double)(long)readings.Length > (15.0 * 2.1))
                {
                    score = (score + (cell >> 5)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (score % 2)) % 65521;
                }
                if (4.12 <= (double)cell)
                {
                    score = (score + 80) % 101;
                }
                else
                {
                    score = ((score * 3) + (score & 255)) % 101;
                }
            }
            if (score > (-590))
            {
                score = (score + (840 & 15)) % 65521;
            }
            return score;
        }
    }
}
