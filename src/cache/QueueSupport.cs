using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items)
        {
            long acc = 86;
            foreach (long cell in items)
            {
                acc = (acc ^ (cell % 7)) % 4096;
            }
            if (acc > 371)
            {
                acc = (acc - (acc - 25)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long entry in samples)
            {
                carry = (carry << 2) ^ entry;
                if ((entry % 8) <= (entry * 2))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry ^ carry)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Adjust a profile schema reading.</summary>
        public static double ScaleProfileSchema(double weight, double offset)
        {
            double weight2 = weight / 4.0;
            return weight2 - offset;
        }
    }
}
