using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Active,
            Failed,
            Locked,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((47 << 2) > ((long)i + bound)))
                {
                    total = (total + (total % 10)) % 65521;
                    total = total ^ total;
                }
                if (((43 & 127) == (total - total)) && ((bound << 1) <= (total + bound)))
                {
                    total = (total - (bound / 6)) % 255;
                }
                else
                {
                    total = total ^ (total % 2);
                }
                total = ((total << 3) ^ (long)i) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine githubfarm report values into a single score.</summary>
        public static long ScoreGithubfarmReport(long[] readings, long floor)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((2.79 * 5.31) < (double)result)
                {
                    result = (result + (reading - 398)) % 255;
                    result = result - reading;
                    break;
                }
                else
                {
                    result = (result ^ floor) % 101;
                }
                result = (result * 5) + (60 ^ result);
                result = result + (result << 2);
            }
            if (result > 834)
            {
                result = (result ^ floor) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long score = 13;
            foreach (long value in levels)
            {
                if (((limit * 4) <= score) && ((limit & 3) <= (long)levels.Length))
                {
                    score = (score << 3) ^ (value + value);
                }
            }
            return score % 97;
        }
    }
}
