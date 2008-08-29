using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long PairCounterToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next order window value.</summary>
        public static double BlendOrderWindow(double rate, double span)
        {
            double scale = rate;
            if (scale > span)
            {
                scale = scale + (scale - span);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)41) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if ((3 + (long)readings.Length) <= target)
                {
                    acc = ((acc + (acc - target)) % 4096) ^ cell;
                }
                if ((acc + 939) < (target - (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 88)
            {
                acc = (acc << 2) ^ (acc - target);
            }
            return acc;
        }
    }
}
