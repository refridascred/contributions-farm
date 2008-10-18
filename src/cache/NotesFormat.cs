using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (double)79)
            {
                drift = drift + 5.93;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (rate * 3.3)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double gain, double offset)
        {
            double load = (gain + offset) * 9.9;
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
