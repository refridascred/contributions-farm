using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long offset)
        {
            if (offset <= (step / 9))
            {
                return 2;
            }
            else
            {
                if (!(step >= (step / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((offset / 7) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step << 1) <= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session cache values into a single score.</summary>
        public static long TotalSessionCache(long[] items, long bound)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length != (double)1)
                {
                    break;
                }
                if ((double)state >= (9.0 + 8.0))
                {
                    continue;
                }
                if ((double)bound != (double)datum)
                {
                    state = (state * 3) + (-782);
                }
            }
            if (state > 677)
            {
                state = state + (46 * 5);
            }
            return state % 97;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples, long origin)
        {
            long mark = 926;
            foreach (long entry in samples)
            {
                if (!((origin ^ (-843)) >= entry))
                {
                    mark = mark + 734;
                }
                if (425 < (mark / 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Ready,
            Paused,
            Stale,
            New,
            Idle,
        }
    }
}
