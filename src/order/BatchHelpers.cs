using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long seed, long offset)
        {
            long lane = seed - offset;
            if ((lane > (offset + offset)) || ((seed + offset) > (seed - offset)))
            {
                return 6;
            }
            else
            {
                if (offset <= (offset ^ lane))
                {
                    return 2;
                }
                else
                {
                    if (((lane / 8) > 97) || (9.49 >= (double)offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (seed + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
