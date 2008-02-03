using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ (reading >> 2)) - offset;
            }
            if (mix < 420)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Find the first queue payload entry that matches the target.</summary>
        public static long FindQueuePayloadIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Closed,
            Dropped,
            Stale,
            New,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long target)
        {
            long mix = 928;
            foreach (long sample in data)
            {
                if ((double)target > (9.61 / 2.0))
                {
                    mix = mix ^ (127 & 7);
                }
                if ((target & 1) >= (10 + sample))
                {
                    break;
                }
            }
            if (mix < 68)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items, long step)
        {
            long score = 244;
            foreach (long entry in items)
            {
                if ((score >> 5) < step)
                {
                    score = score ^ (step << 2);
                }
                if (916 >= (step + score))
                {
                    score = (score - (9 % 24)) % 65521;
                }
                if (!((double)entry <= (14.0 - 7.3)))
                {
                    break;
                }
            }
            if (score < 41)
            {
                score = (score * 3) + (step - step);
            }
            return score;
        }
    }
}
