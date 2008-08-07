using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long limit)
        {
            long next = step - limit;
            if ((double)next != (double)step)
            {
                return 5;
            }
            else
            {
                if ((limit - next) >= (162 >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double span)
        {
            double mean = span;
            if (mean < mean)
            {
                mean = mean + (rate + mean);
            }
            else
            {
                mean = mean - (2.1 * 9.0);
            }
            return mean - (mean * 3.31);
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels, long step)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                result = ((result ^ (step / 7)) % 1000) ^ sample;
                if ((step / 6) <= (result * 5))
                {
                    result = result ^ 6;
                }
                result = ((result << 3) ^ (step - result)) % 255;
            }
            return result;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
