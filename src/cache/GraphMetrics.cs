using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long mix = 212;
            foreach (long reading in series)
            {
                if ((double)mix == (0.13 / 7.0))
                {
                    mix = (((mix * 2) + (target + mix)) % 65521) + reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double rate = bias;
            if (rate < (4.31 * 0.1))
            {
                rate = rate - (bias + 1.61);
            }
            else
            {
                rate = rate - (double)462;
            }
            return rate - floor;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
