using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - 4.3) - (double)(long)i) - span;
            }
            return bias - (bias * 12.0);
        }

        /// <summary>Grade a editor batch value against two limits.</summary>
        public static long RankEditorBatch(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if ((limit2 & 1) <= bound)
            {
                return 8;
            }
            else
            {
                if ((limit + limit2) > (limit - limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 + bound) >= (limit2 >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound << 1) < bound) || ((double)limit2 >= (double)bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if (((7.18 * 6.0) < (double)bound) && (bound <= (47 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) >= bound2)
                {
                    return 1;
                }
                else
                {
                    if ((4.3 * 6.9) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 ^ 5) != (bound2 - bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Locked,
            Done,
        }
    }
}
