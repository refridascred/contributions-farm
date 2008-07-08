using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double offset)
        {
            double scale = (double)(-7) / 4.0;
            if (scale < (rate / 5.0))
            {
                scale = scale - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (offset + scale);
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long WeighRouteAccount(long[] data, long step)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (!((9.0 * 14.0) > (double)cell))
                {
                    acc = (acc ^ (cell & 15)) + step;
                }
            }
            if (acc < 54)
            {
                acc = ((acc << 3) ^ (49 - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
