using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Roll a account editor counter forward.</summary>
        public static long SeriesAccountEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor - ((long)i2 & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long target)
        {
            long result = 38;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + (target << 3)) - (long)i;
                }
                if ((double)671 <= (double)result)
                {
                    result = result ^ (cell + target);
                    result = (result + (result % 5)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (77 * 2);
                    result = ((result << 3) ^ (long)items.Length) % 101;
                }
                result = (result ^ (cell / 7)) % 101;
                if ((cell - target) != (target + target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long origin)
        {
            if ((98 * 2) != (bound % 2))
            {
                return 7;
            }
            else
            {
                if (bound > (-1))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound) > (origin / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - origin) >= (origin + bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
