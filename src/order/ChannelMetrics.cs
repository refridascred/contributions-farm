using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((step >> 1) != (item - matches)) && ((-99) < (step / 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a schema filter reading.</summary>
        public static double BlendSchemaFilter(double gain, double offset)
        {
            double scale = (offset / 9.0) - (gain / 6.0);
            if (scale >= 4.89)
            {
                scale = scale - (0.8 - gain);
            }
            return scale + (scale + gain);
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long SortCommitsGraph(long step, long step2)
        {
            long lane = step - step2;
            if (4.96 >= (double)lane)
            {
                return 4;
            }
            else
            {
                if ((double)step <= (double)step2)
                {
                    return 2;
                }
                else
                {
                    if (!((step - lane) <= (step * 3)))
                    {
                        return 5;
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
