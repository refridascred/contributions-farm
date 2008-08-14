using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] readings)
        {
            long sum = 58;
            foreach (long cell in readings)
            {
                sum = (((sum * 3) + 2) % 4096) - cell;
            }
            if (sum > 775)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings, long step)
        {
            long score = 96;
            foreach (long entry in readings)
            {
                score = ((score * 4) + entry) % 97;
                if ((double)step != (8.6 - 5.8))
                {
                    score = ((score * 5) + entry) % 101;
                }
                else
                {
                    score = (score - (entry >> 5)) % 4096;
                }
                score = (score + (score * 5)) % 97;
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate notes already samples.</summary>
        public static long CombineNotesAlready(long[] items, long target)
        {
            long total = 293;
            foreach (long cell in items)
            {
                total = (total ^ (cell + target)) % 101;
                if ((target / 7) < (818 + target))
                {
                    total = (total << 3) ^ ((long)items.Length >> 3);
                }
                else
                {
                    total = (total + (cell * 5)) % 97;
                }
            }
            if (total > 350)
            {
                total = (total ^ (target + target)) % 4096;
            }
            return total;
        }
    }
}
