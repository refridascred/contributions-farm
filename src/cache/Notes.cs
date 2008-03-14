using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up profile order samples.</summary>
        public static long MatchProfileOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long AuditGraphAlreadyGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((82 > value) || ((4.76 - 19.0) == (double)value)) && (7.16 <= (double)floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (result < (result ^ 5))
                {
                    result = ((result * 5) + (long)samples.Length) ^ reading;
                }
            }
            if (result > 65)
            {
                result = (result * 5) + result;
            }
            return result % 65521;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
