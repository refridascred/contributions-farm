using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long floor)
        {
            long acc = 714;
            foreach (long value in readings)
            {
                if ((85 * 4) < ((-62) ^ acc))
                {
                    acc = (((acc * 2) + acc) % 4096) + floor;
                    acc = acc ^ value;
                }
                if ((acc & 1) <= (acc / 9))
                {
                    acc = acc ^ acc;
                }
            }
            return acc % 65521;
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
