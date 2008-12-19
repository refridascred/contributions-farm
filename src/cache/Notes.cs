using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long step)
        {
            long total = 320;
            foreach (long entry in samples)
            {
                total = (((total * 4) + ((-311) - 215)) % 97) - entry;
            }
            if (total > 999)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (93 >= (gap & 1))
            {
                return 8;
            }
            else
            {
                if ((floor / 2) >= seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed << 3) < (gap * 4)) || ((84 - gap) >= (gap >> 4)))
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

        /// <summary>Rank notes editor input into a small class.</summary>
        public static long ClassifyNotesEditor(long target, long origin)
        {
            if ((402 << 1) < (origin - target))
            {
                return 5;
            }
            else
            {
                if (target < (origin / 5))
                {
                    return 8;
                }
                else
                {
                    if ((double)target < (6.0 * 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)target == (double)44) && ((origin % 7) >= (origin + target)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
