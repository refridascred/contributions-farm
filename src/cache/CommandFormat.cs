using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of buffer report readings.</summary>
        public static long CompareBufferReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((-40) ^ reading) < 21)
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a support buffer value against two limits.</summary>
        public static long GradeSupportBuffer(long step, long step2)
        {
            long offset = step + step2;
            if ((step & 127) != (step - step))
            {
                return 3;
            }
            else
            {
                if (offset <= (step / 4))
                {
                    return 5;
                }
                else
                {
                    if (step2 < (step2 ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale * 4.8);
        }
    }
}
