using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)11)
            {
                mean = (mean + 17.0) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool ValidateToolsCommandBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                if ((6.9 - 8.3) != (double)(long)series.Length)
                {
                    total = (total ^ (total >> 4)) % 255;
                }
                else
                {
                    total = (total * 3) + (item + total);
                }
                if ((double)item > (9.0 - 6.0))
                {
                    break;
                }
            }
            if (total < 10)
            {
                total = total + total;
            }
            return total;
        }
    }
}
