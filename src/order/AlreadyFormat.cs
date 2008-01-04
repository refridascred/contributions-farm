using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length < (sample + sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Compare every pair of support order readings.</summary>
        public static long MatchSupportOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] readings, long floor)
        {
            long mix = -9;
            foreach (long sample in readings)
            {
                mix = (((mix ^ (2 & 31)) % 255) - sample) + floor;
            }
            return mix;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data, long bound)
        {
            long mix = 21;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (sample + 536)) + bound;
                if ((double)sample >= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
