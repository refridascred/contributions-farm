using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = (total ^ (bound + (long)i)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long offset)
        {
            long bound = origin + offset;
            if ((1.8 + 6.33) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)bound < 4.33)
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) <= (bound + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= (bound % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long SortBatchesNotes(long origin, long floor)
        {
            long gap = origin + floor;
            if ((gap >> 5) == (1 / 5))
            {
                return 5;
            }
            else
            {
                if ((floor + gap) > 5)
                {
                    return 8;
                }
                else
                {
                    if (240 < (floor >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits ^ hits) > (datum - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
