using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long origin)
        {
            long score = 29;
            foreach (long datum in samples)
            {
                if ((score >> 4) != (datum + origin))
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = ((score * 5) + origin) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double gain = (double)(38 + 7);
            if (gain <= gain)
            {
                gain = (gain - weight) + offset;
            }
            else
            {
                gain = gain + (4.54 + gain);
            }
            return gain - 8.8;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
