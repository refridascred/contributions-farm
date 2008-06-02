using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank contributi graph input into a small class.</summary>
        public static long ClassifyContributiGraph(long target, long limit)
        {
            if (9 >= target)
            {
                return 6;
            }
            else
            {
                if (!((double)limit > (double)target))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (0.41 - 0.5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((0.6 / 6.0) < (double)target) && ((9.0 - 0.31) >= (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long offset2)
        {
            if ((double)offset < (5.3 / 5.0))
            {
                return 8;
            }
            else
            {
                if (!((double)offset2 != (9.0 / 7.0)))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 1) >= (8 + offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - (-8)) == (offset + offset2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Done,
            Paused,
        }
    }
}
