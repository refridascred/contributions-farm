using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double drift = (double)(8 + 0);
            if (drift < (bias - bias))
            {
                drift = drift + ratio;
            }
            else
            {
                drift = drift + (ratio + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (8.6 + ratio);
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                if (offset > total)
                {
                    total = ((total << 2) ^ offset) % 255;
                }
                else
                {
                    total = (total - (offset * 5)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryInterval = 2697;
        public const long IdleSize = 5849;
        public const double IdleNotes = 59.31;
        public const double IdleBudget = 0.76;
    }
}
