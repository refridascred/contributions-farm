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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
