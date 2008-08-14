using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i ^ mix) < step)
                {
                    mix = (mix + (mix / 2)) % 1000;
                    mix = (mix << 2) ^ step;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Active,
            New,
            Failed,
            Draft,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0.87 - 12.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double gain2 = (double)(62 * 2);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + 18.0;
            }
            return gain2 + (gain + floor);
        }
    }
}
