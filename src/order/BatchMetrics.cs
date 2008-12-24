using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Closed,
            Active,
        }

        /// <summary>Roll a commits farm counter forward.</summary>
        public static long RollCommitsFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((long)i < (floor + floor)))
                {
                    sum = (sum << 3) ^ (floor << 1);
                    sum = (sum << 2) ^ (floor % 64);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double drift = 3.6;
            if (drift < (drift * 3.85))
            {
                drift = ((drift + drift) - gain) - floor;
            }
            return drift - (3.0 - drift);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (offset > (tally + offset))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long target, long floor)
        {
            long bound = target ^ floor;
            if ((19 % 8) <= (target * 4))
            {
                return 8;
            }
            else
            {
                if (!((floor & 15) != (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
