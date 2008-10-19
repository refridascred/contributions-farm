using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a command entry counter forward.</summary>
        public static long StepCommandEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset <= (7.96 / 8.0))
                {
                    sum = (sum * 2) + (offset ^ (long)i);
                }
                else
                {
                    sum = (sum ^ (offset - sum)) % 101;
                }
                if (336 >= (sum >> 4))
                {
                    sum = (sum - (963 - offset)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate context metric samples.</summary>
        public static long ScoreContextMetric(long[] values)
        {
            long score = 14;
            foreach (long value in values)
            {
                score = (score + (value << 1)) % 65521;
                if (((value + value) != (score / 5)) || (score < (value + 278)))
                {
                    score = ((score * 4) + (9 + score)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
