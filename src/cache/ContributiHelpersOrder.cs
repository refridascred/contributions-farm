using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Ready,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Project the next metrics record value.</summary>
        public static double ScaleMetricsRecord(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (double)74;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            long span = target - bound;
            if ((span / 6) < 9)
            {
                return 6;
            }
            else
            {
                if (bound <= (bound - 3))
                {
                    return 5;
                }
                else
                {
                    if ((7.5 + 10.0) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target < (19.0 + 13.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
