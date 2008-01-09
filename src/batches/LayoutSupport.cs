using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Measure how many editor counter samples are out of range.</summary>
        public static long AuditEditorCounterHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum >= (matches + datum)) || ((matches / 4) == (limit % 8))) && (((4.3 + 0.86) >= (double)datum) && ((datum >> 1) <= (limit << 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already editor value against two limits.</summary>
        public static long GradeAlreadyEditor(long floor, long limit)
        {
            if ((double)limit < (8.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
