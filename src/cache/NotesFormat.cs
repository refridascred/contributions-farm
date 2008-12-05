using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long target)
        {
            if (53 > (step - step))
            {
                return 3;
            }
            else
            {
                if (((target * 3) < (target + target)) || ((target + target) > (target >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (((double)step < (6.4 - 8.0)) || ((3 << 2) == (step & 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample - seen) != (seen - (-4)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
