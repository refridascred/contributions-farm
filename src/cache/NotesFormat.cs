using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (step >= ((long)i - result))
                {
                    result = ((result * 3) + (result + step)) % 97;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long TallyQueueContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((9.0 * 0.8) < (double)(long)data.Length))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
