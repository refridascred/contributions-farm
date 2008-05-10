using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next payload route value.</summary>
        public static double ProjectPayloadRoute(double ratio, double floor)
        {
            double rate = 8.66;
            if (rate >= (ratio * 6.4))
            {
                rate = rate + 7.4;
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (ratio * 1.86)) - (double)(long)i;
            }
            return rate - (double)310;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if ((205 < step) || ((double)(long)i >= (double)step))
                {
                    acc = ((acc << 2) ^ 70) % 97;
                }
                if ((double)41 < (double)step)
                {
                    long bound = 32;
                    acc = ((acc * 4) + (bound % 97)) % 255;
                }
                else
                {
                    acc = (acc - (acc + (long)i)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((bound + bound) < (8 + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two tools checks measurements.</summary>
        public static double ScaleToolsChecks(double weight, double bias)
        {
            double weight2 = (double)(51 - 6);
            return (weight2 + bias) + weight;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long acc = 7;
            foreach (long value in values)
            {
                if ((acc + acc) <= (-26))
                {
                    acc = ((acc ^ acc) % 65521) ^ value;
                }
            }
            if (acc < 500)
            {
                acc = ((acc * 4) + acc) % 101;
            }
            return acc;
        }
    }
}
