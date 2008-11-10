using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell + limit) == (cell ^ cell)) && ((double)cell < (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate channel support readings against a bound.</summary>
        public static bool GuardChannelSupportLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long AuditFarmToolsOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((-1) * 3) <= tally)
                {
                    tally = ((tally + 1) - datum) + step;
                }
            }
            return tally;
        }
    }
}
