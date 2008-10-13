using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset + 5) > (total - 85))
                {
                    total = (total ^ (total * 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total + offset)) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of support cache readings.</summary>
        public static long TotalSupportCache(long[] series, long origin)
        {
            long carry = 0;
            foreach (long item in series)
            {
                if ((3 + item) < item)
                {
                    carry = ((carry ^ (item >> 2)) % 101) + origin;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long bound)
        {
            long result = 31;
            foreach (long sample in values)
            {
                result = (((result + result) % 1000) + sample) + bound;
            }
            return result;
        }

        /// <summary>Scale a payload context figure with a bias.</summary>
        public static double AdjustPayloadContext(double weight, double span)
        {
            double load = weight;
            if (load > (weight / 8.0))
            {
                load = load - weight;
            }
            else
            {
                load = load - (span / 3.0);
            }
            return load + (load - span);
        }
    }
}
