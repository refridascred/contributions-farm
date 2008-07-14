using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long MeasureFilterBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum & 15) >= (16 & 127)) && ((9.5 * 2.69) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long offset, long step)
        {
            if ((double)89 < (double)step)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) > (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((step & 31) == (599 / 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step <= (offset + 49)) || ((offset & 7) > (step + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + (bias * 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (double)585;
        }
    }
}
