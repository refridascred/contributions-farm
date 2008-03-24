using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 58.25;
        public const double LimitSupport = 49.58;
        public const long MinSupport = 3351;
        public const long RetryTimeout = 5449;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry ^ carry) % 65521) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((13 % 60) <= (value & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                if ((sample + step) > (133 ^ step))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 3) + (sample - step)) % 65521;
                }
                mark = (mark << 3) ^ (sample << 1);
                if ((step - sample) < (115 + mark))
                {
                    mark = mark ^ ((long)values.Length - 8);
                }
                if ((step >> 3) >= (8 - step))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (374 ^ step)) % 1000;
            }
            return mark;
        }
    }
}
