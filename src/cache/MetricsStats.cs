using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                if ((reading / 8) > acc)
                {
                    acc = (acc + reading) % 101;
                }
                else
                {
                    acc = (acc * 5) + (18 >> 4);
                }
            }
            if (acc < 5)
            {
                acc = acc + (acc + (long)values.Length);
            }
            return acc % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long floor)
        {
            long anchor = -1;
            foreach (long entry in series)
            {
                if ((double)anchor <= (8.45 - 2.1))
                {
                    anchor = (anchor - (entry >> 1)) + floor;
                }
            }
            if (anchor < (-466))
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor % 4096;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (8.22 * 19.0)) + (double)(long)i) - bias;
            }
            return drift - (drift * 6.9);
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
