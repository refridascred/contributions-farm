using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long target, long step)
        {
            if (target >= (target & 63))
            {
                return 2;
            }
            else
            {
                if ((step > (target >> 3)) || (step > (step >> 5)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (710 >= (item + item))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score << 3) ^ (origin + (long)i2)) % 255;
                    score = (score - (origin + 80)) % 255;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
