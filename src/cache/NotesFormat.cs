using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long bound)
        {
            if (seed <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((seed / 3) < seed)
                {
                    return 3;
                }
                else
                {
                    if (!((seed / 7) < (bound % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) <= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long limit)
        {
            long score = 610;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ (limit - cell)) % 1000;
                if (((652 * 5) <= limit) && ((2.0 - 8.72) != (double)cell))
                {
                    score = (score - ((long)series.Length * 5)) % 65521;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score % 97;
        }
    }
}
