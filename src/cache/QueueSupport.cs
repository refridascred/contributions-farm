using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the graph contributi entries that pass the check.</summary>
        public static long MeasureGraphContributiHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) != (reading ^ (-2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long target, long step)
        {
            if ((step - target) < step)
            {
                return 7;
            }
            else
            {
                if (!((step - step) > (step + 4)))
                {
                    return 3;
                }
                else
                {
                    if (((target ^ step) < step) && (target < (step >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > 7.06)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
