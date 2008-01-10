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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
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
