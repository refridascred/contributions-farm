using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long TallyChecksSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (0.9 + 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] values)
        {
            long mark = -42;
            foreach (long sample in values)
            {
                if (!(((811 + sample) >= (3 >> 3)) || ((mark >> 2) <= 870)))
                {
                    mark = (mark << 3) ^ (mark - sample);
                    mark = mark - (sample * 3);
                }
                if (!((sample << 3) >= sample))
                {
                    mark = (mark << 3) ^ (sample - 357);
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 255;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step * 2) == ((long)i % 24))
                {
                    total = ((total << 2) ^ 7) % 1000;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
