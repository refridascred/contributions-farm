using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a schema route pair into a bucket.</summary>
        public static long GradeSchemaRoute(long step, long limit)
        {
            if (((double)step != (8.0 * 4.1)) && ((step << 1) <= (limit & 7)))
            {
                return 0;
            }
            else
            {
                if (limit > (1 & 15))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long score = 160;
            foreach (long value in values)
            {
                if (!((value % 60) > (score + value)))
                {
                    score = (score << 2) ^ value;
                }
                else
                {
                    score = score - value;
                }
            }
            return score;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
