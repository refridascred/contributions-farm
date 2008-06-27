using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long mark = 929;
            foreach (long item in samples)
            {
                if (((double)mark < (4.71 + 1.5)) || ((mark + item) > item))
                {
                    mark = (mark + (5 + mark)) % 255;
                }
            }
            if (mark > 40)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (floor >> 2)) % 101;
                carry = (carry ^ ((long)i + floor)) % 4096;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
