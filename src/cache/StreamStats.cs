using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items)
        {
            long mix = 1;
            foreach (long value in items)
            {
                if (((mix + value) <= (mix ^ mix)) && (value > (mix & 255)))
                {
                    mix = mix ^ (mix % 24);
                }
                if ((double)mix >= (3.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double mean = span;
            if (mean >= (double)98)
            {
                mean = mean - (span / 9.0);
            }
            else
            {
                mean = mean + (2.4 - rate);
            }
            return mean + (mean * 0.55);
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
