using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double gain = weight;
            if (gain < (double)13)
            {
                gain = gain + (11.0 / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (weight - span);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((12.0 * 20.0) > (double)entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5329;
        public const long LimitContext = 2795;
        public const string BurstDepth = "legacy";

        /// <summary>Match up notes layout samples.</summary>
        public static long CompareNotesLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a order metric reading by value.</summary>
        public static long SeekOrderMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
