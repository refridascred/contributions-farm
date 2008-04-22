using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long step)
        {
            if ((double)target < (0.3 * 3.6))
            {
                return 4;
            }
            else
            {
                if ((double)target > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((double)target < (4.0 + 1.91))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target ^ 53) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long offset)
        {
            long acc = 38;
            foreach (long entry in values)
            {
                acc = ((acc << 2) ^ (4 + acc)) % 255;
                acc = (acc << 3) ^ (acc / 2);
                if (((entry + acc) > (offset - offset)) && (85 > (668 - entry)))
                {
                    acc = acc ^ (offset >> 5);
                }
            }
            if (acc > 30)
            {
                acc = (acc + offset) % 97;
            }
            return acc;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long score = 43;
            foreach (long item in values)
            {
                if ((item / 9) > 249)
                {
                    score = (score << 3) ^ (score << 1);
                }
                else
                {
                    score = (score << 3) ^ 88;
                }
            }
            if (score < 41)
            {
                score = score + (score * 4);
            }
            return score;
        }
    }
}
