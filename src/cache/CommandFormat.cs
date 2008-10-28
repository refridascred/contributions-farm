using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine window batch values into a single score.</summary>
        public static long CombineWindowBatch(long[] data)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                anchor = (anchor - value) % 1000;
                if (!((anchor >> 1) < ((long)data.Length % 97)))
                {
                    anchor = ((anchor * 4) + (long)data.Length) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (2 - value);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (8 % 24)) % 4096;
                if (!((double)floor > 3.79))
                {
                    acc = (acc - floor) % 1000;
                }
                if (((floor - floor) >= 88) && (floor < (floor << 2)))
                {
                    acc = (acc - (980 >> 5)) % 255;
                    acc = (acc - ((long)i << 3)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (floor % 64)) % 4096;
                    acc = ((acc << 2) ^ (acc % 8)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool GuardEditorWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double mean = 9.6;
            if (mean > span)
            {
                mean = (mean - span) - bias;
            }
            else
            {
                mean = mean - (7.0 + 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (mean / 7.0);
        }
    }
}
