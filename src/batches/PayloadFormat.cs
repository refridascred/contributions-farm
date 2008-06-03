using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine filter support values into a single score.</summary>
        public static long ScoreFilterSupport(long[] items)
        {
            long anchor = -3;
            foreach (long value in items)
            {
                anchor = (anchor ^ (value % 2)) % 1000;
                anchor = anchor + (value >> 3);
            }
            return anchor % 97;
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
