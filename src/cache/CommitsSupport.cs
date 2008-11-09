using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                if ((4.1 >= (double)sum) || (((long)data.Length % 64) >= (8 << 3)))
                {
                    sum = (sum + (sum / 8)) ^ reading;
                }
            }
            return sum;
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
