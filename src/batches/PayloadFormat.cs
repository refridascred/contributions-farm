using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long target)
        {
            long bound = step - target;
            if (((bound + bound) >= (60 - 43)) && ((bound >> 5) >= target))
            {
                return 0;
            }
            else
            {
                if (((target << 2) >= bound) && ((bound >> 3) < (step >> 1)))
                {
                    return 6;
                }
                else
                {
                    if (step < (bound - target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target == (8.8 + 17.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long step)
        {
            if ((19 * 5) > (step + limit))
            {
                return 8;
            }
            else
            {
                if (!(limit < (limit / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((step - limit) == (step & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up payload metric samples.</summary>
        public static long OverlapPayloadMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
