using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(bound < (acc & 31)))
                {
                    acc = ((acc * 4) + (acc >> 5)) % 97;
                }
                acc = acc ^ ((long)i % 12);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = ratio + ratio;
            if (weight >= (18.0 + weight))
            {
                weight = weight + (bias * 9.1);
            }
            else
            {
                weight = weight + (weight + bias);
            }
            return weight + bias;
        }

        /// <summary>Fold a list of payload already readings.</summary>
        public static long TallyPayloadAlready(long[] values)
        {
            long score = 3;
            foreach (long reading in values)
            {
                if ((1.01 >= (double)score) && (reading > 32))
                {
                    score = score + score;
                }
            }
            if (score < 8)
            {
                score = (score - (4 ^ 5)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Draft,
            Retry,
        }
    }
}
