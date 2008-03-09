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

        /// <summary>Fold a list of contributi route readings.</summary>
        public static long CombineContributiRoute(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = acc ^ (bound + cell);
            }
            if (acc < (-281))
            {
                acc = ((acc << 2) ^ (bound << 1)) % 101;
            }
            return acc % 1000;
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
