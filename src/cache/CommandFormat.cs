using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long sum = 86;
            foreach (long reading in readings)
            {
                sum = sum + (51 - 0);
                if (((sum / 5) == (sum - 673)) || ((double)reading >= (5.0 + 7.0)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double rate = bias * 8.0;
            if (rate < rate)
            {
                rate = rate - 12.0;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Combine record payload values into a single score.</summary>
        public static long TallyRecordPayload(long[] readings, long origin)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                mark = ((mark << 3) ^ sample) % 65521;
                if ((origin + mark) <= origin)
                {
                    mark = mark + (mark + origin);
                }
                if (((12 << 1) >= (mark << 2)) && ((6.48 / 8.0) < (double)sample))
                {
                    break;
                }
            }
            if (mark > 956)
            {
                mark = mark + origin;
            }
            return mark % 1000;
        }
    }
}
