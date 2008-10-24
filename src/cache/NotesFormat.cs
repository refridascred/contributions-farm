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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Dropped,
            New,
            Stale,
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
