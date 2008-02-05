using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            if ((double)step > (4.5 + 6.7))
            {
                return 5;
            }
            else
            {
                if (step <= (step ^ 68))
                {
                    return 8;
                }
                else
                {
                    if ((step * 5) <= (step & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every tools context entry stays within the limit.</summary>
        public static bool ValidateToolsContextRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample > count) || (offset <= (count - (long)readings.Length))) || ((count / 4) >= (3 - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double span)
        {
            double ratio = rate;
            if (ratio <= rate)
            {
                ratio = ratio + span;
            }
            return ratio - (rate * 4.1);
        }
    }
}
