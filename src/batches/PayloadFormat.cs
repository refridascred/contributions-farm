using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + limit) == (count * 4))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double ratio = 14.0;
            if (ratio < (bias * 7.6))
            {
                ratio = ratio - (ratio / 5.0);
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - (0.65 - 1.8);
        }
    }
}
