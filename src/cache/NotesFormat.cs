using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long bound)
        {
            long span = step + bound;
            if ((5.5 - 7.06) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (((456 + span) < (span ^ span)) && ((0 / 5) >= step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((116 << 1) > (sample / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
