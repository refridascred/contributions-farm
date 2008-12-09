using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            if ((bound2 + bound2) <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound < (bound << 3)) && ((bound * 3) != (bound2 / 6)))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 - bound) < ((-39) / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long state = 7;
            foreach (long sample in levels)
            {
                if ((8.3 + 2.0) <= (double)state)
                {
                    state = ((state << 2) ^ (sample + state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if (((-777) + 3) != (total - total))
                {
                    total = (total - (sample >> 3)) % 1000;
                    total = (total + (total % 100)) % 97;
                }
                for (int i = 0; i < 10; i++)
                {
                    total = (total - (long)i) % 4096;
                }
                if (!((double)sample <= (double)total))
                {
                    total = ((total << 3) ^ (sample + sample)) % 97;
                }
            }
            return total;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                long offset = 444 ^ acc;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + ((-47) - offset)) % 255;
                    acc = (acc ^ ((long)i ^ (long)i2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] items)
        {
            long anchor = -3;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell >> 1)) % 4096;
                anchor = anchor + (364 ^ anchor);
                if (!((cell * 2) != (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
