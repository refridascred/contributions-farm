using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every tools batches entry stays within the limit.</summary>
        public static bool VerifyToolsBatchesLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target ^ (long)i) != (1 / 9))
                {
                    score = ((score << 2) ^ 474) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes cache entries that pass the check.</summary>
        public static long AuditNotesCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (4.6 * 19.0))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
