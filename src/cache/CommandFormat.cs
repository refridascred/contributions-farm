using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] samples, long limit)
        {
            long score = 35;
            foreach (long value in samples)
            {
                if (!((score + (long)samples.Length) >= (7 - limit)))
                {
                    break;
                }
                else
                {
                    score = ((score ^ (limit ^ score)) % 65521) ^ value;
                }
                score = score + limit;
                if ((221 * 4) > (466 - score))
                {
                    score = (score + 38) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double load = scale;
            return (load + (load * 7.16)) + offset;
        }

        /// <summary>Rank graph farm input into a small class.</summary>
        public static long ClassifyGraphFarm(long limit, long floor)
        {
            long cur = limit + floor;
            if (!((double)cur >= (double)floor))
            {
                return 0;
            }
            else
            {
                if ((cur - limit) > cur)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
