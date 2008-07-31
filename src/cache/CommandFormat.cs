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

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Done,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double load = scale;
            return (load + (load * 7.16)) + offset;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long limit)
        {
            if (!((step >> 2) == (limit + step)))
            {
                return 3;
            }
            else
            {
                if (!((limit << 2) == (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
