using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up queue stats samples.</summary>
        public static long PairQueueStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate channel queue samples.</summary>
        public static long DigestChannelQueue(long[] values, long bound)
        {
            long mix = -695;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix + (long)i;
                    mix = ((mix << 3) ^ (mix - 607)) % 101;
                }
                if ((value / 3) <= bound)
                {
                    mix = (mix + bound) % 101;
                }
                else
                {
                    mix = mix - (bound ^ mix);
                }
            }
            if (mix > 65)
            {
                mix = (mix + (bound & 3)) % 97;
            }
            return mix % 65521;
        }
    }
}
