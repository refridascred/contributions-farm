using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long bound)
        {
            long diff = floor + bound;
            if (!(floor > 3))
            {
                return 2;
            }
            else
            {
                if (272 > (floor & 127))
                {
                    return 5;
                }
                else
                {
                    if (((-99) & 1) == (diff / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff >= (-813))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long WeighOrderStream(long[] samples, long step)
        {
            long carry = 972;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (step - reading)) % 65521;
                if ((double)step < (10.0 - 4.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((39 * 3) >= (value % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] samples, long offset)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                mark = mark + (sample << 2);
                if (offset <= (offset % 100))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
