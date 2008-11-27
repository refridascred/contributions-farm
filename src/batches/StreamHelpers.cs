using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum ^ 555) % 255) - (long)i2;
                }
                if (((sum + step) > (step / 5)) && ((sum / 6) > ((long)i + sum)))
                {
                    sum = sum + 4;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double rate2 = (double)578 / 8.0;
            if (rate2 < 8.0)
            {
                rate2 = (rate2 - (double)4) - offset;
            }
            return rate2 - rate;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long origin, long origin2)
        {
            if ((double)origin2 <= (19.0 + 6.0))
            {
                return 3;
            }
            else
            {
                if (!((double)origin2 > (1.7 * 9.3)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > 9.66)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state ^ reading)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Done,
            Failed,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
