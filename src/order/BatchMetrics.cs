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

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((origin - item) != (seen % 8)) || ((seen * 5) == (item + origin))) || ((double)item != (18.0 / 9.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
