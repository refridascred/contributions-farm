using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell < (cell & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double weight = offset;
            if (weight > (weight + weight))
            {
                weight = (weight - 7.11) + gain;
            }
            return weight + (weight * 6.0);
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double load = floor;
            if (load > (double)873)
            {
                load = load + (gain / 2.0);
            }
            else
            {
                load = load - (load / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Failed,
            Idle,
        }
    }
}
