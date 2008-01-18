using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2107;
        public const long WindowLevel = 5377;
        public const string BatchNotes = "legacy-edge";
        public const long MinTimeout = 4758;
        public const double DefaultCount = 90.74;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double mean = (double)(2 * 4);
            if (mean <= (mean + rate))
            {
                mean = mean - (9.0 + rate);
            }
            else
            {
                mean = mean - (rate - span);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)594) + (double)(long)i;
            }
            return mean - (rate * 5.6);
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Score { get; set; }
        }
    }
}
