using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mix = -37;
            foreach (long value in samples)
            {
                mix = (mix - (value >> 2)) % 65521;
                if (mix >= (0 >> 2))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix - (mix - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double mean = 4.3 * 14.0;
            if (mean <= mean)
            {
                mean = mean - (19.0 + floor);
            }
            else
            {
                mean = mean - (bias + bias);
            }
            return mean - (double)60;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double floor)
        {
            double rate2 = 4.66;
            if (rate2 <= rate)
            {
                rate2 = rate2 + (rate2 - floor);
            }
            return rate2 - (double)12;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
