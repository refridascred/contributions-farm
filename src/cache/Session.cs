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

        /// <summary>Digest a series of counter farm entries.</summary>
        public static long TallyCounterFarm(long[] series)
        {
            long carry = 19;
            foreach (long cell in series)
            {
                carry = ((carry * 4) + (cell % 24)) % 1000;
                if ((carry + 590) < carry)
                {
                    carry = (carry << 2) ^ (cell + 3);
                }
            }
            return carry % 65521;
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
