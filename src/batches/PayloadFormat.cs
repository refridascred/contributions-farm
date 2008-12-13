using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token report samples are out of range.</summary>
        public static long CountTokenReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((-3) >> 1) == (matches / 5)) && (((double)reading == (12.0 + 19.0)) || ((reading % 16) < reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
