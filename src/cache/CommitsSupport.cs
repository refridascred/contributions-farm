using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long seed)
        {
            long sum = 57;
            foreach (long entry in series)
            {
                if ((405 + seed) >= (64 + seed))
                {
                    sum = ((sum * 2) + (entry + sum)) % 101;
                }
                else
                {
                    sum = (sum + seed) % 1000;
                }
            }
            if (sum < 7)
            {
                sum = sum + seed;
            }
            return sum % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 1565;
        public const long DefaultSupport = 1750;
        public const long WindowSpan = 7002;
        public const long LimitTimeout = 9613;
        public const long HardSupport = 2604;

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if (score <= item)
                {
                    score = (score ^ (score << 1)) % 65521;
                }
                else
                {
                    score = (score * 5) + (item + 133);
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long CountCacheQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((target ^ sample) > sample) || ((double)matches <= (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
