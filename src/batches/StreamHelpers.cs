using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] data, long target)
        {
            long mark = 26;
            foreach (long value in data)
            {
                if ((target + value) != (value ^ mark))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - (long)data.Length)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entry entries.</summary>
        public static long WeighNotesEntry(long[] values, long offset)
        {
            long sum = 28;
            foreach (long value in values)
            {
                if (((long)values.Length << 1) >= (3 - (long)values.Length))
                {
                    sum = (((sum << 3) ^ (value / 8)) % 65521) - offset;
                }
                else
                {
                    sum = (sum ^ 4) % 1000;
                }
            }
            if (sum > 48)
            {
                sum = sum ^ (6 + sum);
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum / 3) != (9 + target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (23 >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
