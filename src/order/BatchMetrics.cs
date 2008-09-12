using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long SeriesAlreadyCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long CombineCommandCounter(long[] values)
        {
            long mix = 0;
            foreach (long entry in values)
            {
                if ((496 % 97) != (mix << 2))
                {
                    mix = ((mix - (9 + mix)) % 255) ^ entry;
                }
                if ((mix % 5) != (mix ^ (long)values.Length))
                {
                    break;
                }
            }
            if (mix < 71)
            {
                mix = (mix - (mix & 1)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Idle,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc > 97) && ((acc - step) != ((long)i - step))))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                acc = (acc + step) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long origin)
        {
            long edge = step + origin;
            if ((step + origin) == (841 & 63))
            {
                return 0;
            }
            else
            {
                if ((edge & 15) > (step + step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
