using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long limit2)
        {
            long delta = limit - limit2;
            if ((3 + delta) <= (451 + limit2))
            {
                return 1;
            }
            else
            {
                if ((limit > ((-90) >> 2)) || ((limit % 60) < (limit2 / 2)))
                {
                    return 8;
                }
                else
                {
                    if (((0 + delta) < (limit * 4)) || (limit2 < limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 * 7.01) >= (double)delta)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch commits readings.</summary>
        public static long FoldBatchCommits(long[] data, long step)
        {
            long score = 9;
            foreach (long item in data)
            {
                if ((18.0 / 9.0) > (double)(long)data.Length)
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (item + item)) % 1000;
                }
                if (((item - 1) <= step) || ((item - item) > (4 - 451)))
                {
                    score = score - (624 * 4);
                }
            }
            if (score < 9)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }
    }
}
